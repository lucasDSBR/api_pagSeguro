

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

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "1.0.0",
        Title = "API",
        Description = "API de pagamentos via cartão de credito, PIX, Boleto ou transferências. ",
        Contact = new OpenApiContact
        {
            Name = "Lucas Silva",
            Email = "lucasmaciel6690@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/lucas-silva82/"),
        }
    });
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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
