using Microsoft.EntityFrameworkCore;
using Repositorio;
using Repositorio.Data;
using Repositorio.Interfaces;
using Servicio;
using Servicio.Interfaces;
using Servicio.Mapeo;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("conex");
//Inyecciones de dependencias
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddDbContext<AppDbContext>(op=>op.UseSqlServer(connectionString));
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
