using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.DAL.Repositories;
using MotoEgzaminM2.Mapper;
using MotoEgzaminM2.Services;
using MotoEgzaminM2.Services.Interfaces;
using Serilog;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Secrets.json");

var mapConfig = new AutoMapper.MapperConfiguration(c =>
{
    c.AddProfile(new AuthorProfile());
    c.AddProfile(new EduMaterialReviewProfile());
    c.AddProfile(new EduMaterialProfile());
    c.AddProfile(new EduMaterialTypeProfile());
});
var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();


builder.Services.AddCors(p => p.AddPolicy("default", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
builder.Logging.AddSerilog(logger);

builder.Services.AddDbContext<MotoEgzaminM2Context>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("myConxStr")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEduMaterialRepository, EduMaterialRepository>();
builder.Services.AddScoped<IEduMaterialReviewRepository, EduMaterialReviewRepository>();
builder.Services.AddScoped<IEduMaterialTypeRepository, EduMaterialTypeRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IEduMaterialService, EduMaterialService>();
builder.Services.AddScoped<IEduMaterialReviewService, EduMaterialReviewService>();
builder.Services.AddScoped<IEduMaterialTypeService, EduMaterialTypeService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using Bearer scheme(\"bearer {token}\"))",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddSwaggerGen(c => c.EnableAnnotations());
var mapper = mapConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("corsapp");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
