using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IEduMaterialRepository, EduMaterialRepository>();
builder.Services.AddScoped<IEduMaterialReviewRepository, EduMaterialReviewRepository>();
builder.Services.AddScoped<IEduMaterialTypeRepository, EduMaterialTypeRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
