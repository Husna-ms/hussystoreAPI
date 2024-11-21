using HusstoreAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add database connection (SQL Server)
builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer("Server=DESKTOP-I1TOG0J\\MSSQLSERVER01;Database=HussystoreDB;Trusted_Connection=True;TrustServerCertificate=True;"));


// Add Swagger for API documentation
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
