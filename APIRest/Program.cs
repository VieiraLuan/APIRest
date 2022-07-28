using Microsoft.EntityFrameworkCore;
using TemplateApplication.AutoMapper;
using TemplateApplication.Interfaces;
using TemplateApplication.Services;
using TemplateData.Context;
using TemplateData.Repositories;
using TemplateDomain.Interfaces;
using TemplateIoc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inserindo Banco de Dados
var connectionString = builder.Configuration.GetConnectionString("databaseUrl");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString).EnableSensitiveDataLogging(true));

//Inserindo IoC
var services = builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
NativeInjector.RegistrarServicos(services);

var repositorio = builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
NativeInjector.RegistrarServicos(repositorio);

//InserindoAutoMapper
services.AddAutoMapper(typeof(AutoMapperSetup));

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
