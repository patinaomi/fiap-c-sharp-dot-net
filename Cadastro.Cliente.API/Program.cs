using Cadastro.Cliente.API.Domain.Interface;
using Cadastro.Cliente.API.Infraestructure.Data.AppData;
using Cadastro.Cliente.API.Infraestructure.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(
        builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();