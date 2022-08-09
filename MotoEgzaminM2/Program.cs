using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.DAL.Repositories;
using MotoEgzaminM2.Mapper;
using MotoEgzaminM2.Services;
using MotoEgzaminM2.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var mapConfig = new AutoMapper.MapperConfiguration(c =>
{
    c.AddProfile(new AuthorProfile());

});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<MotoEgzaminM2Context>(builder =>
{
    builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MotoEgzaminM2;Integrated Security=True");
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEduMaterialRepository, EduMaterialRepository>();
builder.Services.AddScoped<IEduMaterialReviewRepository, EduMaterialReviewRepository>();
builder.Services.AddScoped<IEduMaterialTypeRepository, EduMaterialTypeRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IEduMaterialService, EduMaterialService>();
builder.Services.AddScoped<IEduMaterialReviewService, EduMaterialReviewService>();
builder.Services.AddScoped<IEduMaterialTypeService, EduMaterialTypeService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapper = mapConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
