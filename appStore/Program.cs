

using appStore.Interfaces.PagSeguroInterfaceService;
using appStore.Services.PagSeguroService;
using appStore.Services.PedidosService;
using appStore.Repositories.PedidosRepository;
using appStore.Context;
using Microsoft.EntityFrameworkCore;
using appStore.Interfaces.UsuariosInterfaceService;
using appStore.Services.UsuariosService;
using appStore.Interfaces.Repository.UsuariosInterfaceRepository;
using appStore.Interfaces.PedidosInterfaceRepository;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoStrSqlServer"))
    );  

builder.Services.AddScoped<IPagSerguroInterfaceService, PagSeguroService>();
builder.Services.AddScoped<IPedidosInterfaceService, PedidosService>();
builder.Services.AddScoped<IUsuariosInterfaceService, UsuariosService>();
builder.Services.AddScoped<IUsuariosInterfaceRepository, UsuariosRepository>();
builder.Services.AddScoped<IPedidosInterfaceRepository, PedidosRepository>();


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
