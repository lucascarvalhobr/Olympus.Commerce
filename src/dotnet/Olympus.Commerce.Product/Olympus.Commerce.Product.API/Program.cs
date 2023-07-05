using Microsoft.EntityFrameworkCore;
using Olympus.Commerce.Product.Infra;
using Olympus.Commerce.Product.Infra.Repositories;
using Olympus.Commerce.Product.Infra.Services;
using Olympus.Commerce.Product.Repositories;
using Olympus.Commerce.Product.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProductDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("OlympusDatabase"),
            x => x.MigrationsAssembly("Olympus.Commerce.Product.Infra")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
