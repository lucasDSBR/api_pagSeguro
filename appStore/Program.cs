

using api.Interfaces.PagSeguroInterfaceService;
using api.Services.PagSeguroService;
using api.Services.PedidosService;
using api.Repositories.PedidosRepository;
using api.Context;
using Microsoft.EntityFrameworkCore;
using api.Interfaces.UsuariosInterfaceService;
using api.Services.UsuariosService;
using api.Interfaces.Repository.UsuariosInterfaceRepository;
using api.Interfaces.PedidosInterfaceRepository;
using api.Services;
using api.Interfaces.PagamentosInterfaceService;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Schema;
using api.Interfaces.PlanoInterfaceService;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nome do Projeto", Version = "1.0" });
});

builder.Services.AddDbContext<MyContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoStrSqlServer"))
    );  

builder.Services.AddScoped<IPagSerguroInterfaceService, PagSeguroService>();
builder.Services.AddScoped<IPedidosInterfaceService, PedidosService>();
builder.Services.AddScoped<IUsuariosInterfaceService, UsuariosService>();
builder.Services.AddScoped<IUsuariosInterfaceRepository, UsuariosRepository>();
builder.Services.AddScoped<IPedidosInterfaceRepository, PedidosRepository>();
builder.Services.AddScoped<IPagamentosInterfaceService, PagamentosService>();
builder.Services.AddScoped<IPlanoInterfaceService, PlanoService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger.json", "Nome do Projeto");
        c.RoutePrefix = string.Empty;
    });
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
