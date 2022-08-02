using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Template.Auth.Models;
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

#region Configuracoes

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

//InserindoJwt

var key = Encoding.ASCII.GetBytes(Settings.Secret);
services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
#region Autenticao
app.UseAuthentication();
app.UseAuthorization();

#endregion
app.MapControllers();

app.Run();
