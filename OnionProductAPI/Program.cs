using Microsoft.EntityFrameworkCore;
using OnionProductAPI.Application.Interfaces;
using OnionProductAPI.Application.Services;
using OnionProductAPI.Domain.Interfaces;
using OnionProductAPI.Infrastructure.Data;
using OnionProductAPI.Infrastructure.Repositories;
using FluentValidation;
using OnionProductAPI.API.Validators;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
    .AddFluentValidation(config =>
    {
        builder.Services.AddValidatorsFromAssemblyContaining<ProductDtoValidator>();
    });

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
