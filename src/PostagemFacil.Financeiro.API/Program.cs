using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PostagemFacil.Financeiro.API.Business;
using PostagemFacil.Financeiro.API.Data;

var builder = WebApplication.CreateBuilder(args);
var dbConnection = builder.Configuration.GetConnectionString("Default");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FinanceiroContext>(opt => opt.UseSqlServer(dbConnection)) ;
builder.Services.AddScoped<ICustosService, CustosService>();

var corsPolicy = new CorsPolicyBuilder().AllowAnyHeader().AllowAnyOrigin().Build();
builder.Services.AddCors(opt => opt.AddDefaultPolicy(corsPolicy));

var app = builder.Build();

app.UseSwagger().UseSwaggerUI();

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
