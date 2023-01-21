using AutoMapper;
using KonterPulsa.Application.ConfigProfile;
using KonterPulsa.Application.Services.Customers;
using KonterPulsa.Database.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//context database
var Conn = builder.Configuration.GetConnectionString("Conn");
builder.Services.AddDbContext<TokoContext>(opt =>
{
	opt.UseSqlServer(Conn);
});

//automapper
var config = new MapperConfiguration(cfg =>
{
	cfg.AddProfile(new ConfigurationProfile());
});

var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

// Add services to the container.
builder.Services.AddTransient<ICustomerAppService, CustomerAppService>();

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
