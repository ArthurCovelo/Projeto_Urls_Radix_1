using Domain.Interfaces;
using Infra.Config;
using Infra.Repositorio;
using Microsoft.EntityFrameworkCore;
using Service;
using Service.Validation;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUrlRepository, UrlRepository>();
builder.Services.AddScoped<UrlService>();
builder.Services.AddScoped<Validacoes>();
builder.Services.AddDbContext<UrlDbContext>(options =>
options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


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
