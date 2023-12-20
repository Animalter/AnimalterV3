using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Concrete;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Abstract.Entites;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.Context;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region ServiceAndRepoRegister
//Ödev1
builder.Services.AddTransient<ICustomerService, CustomerManager>();
builder.Services.AddTransient<ICustomerDal, EfCustomerDal>();

builder.Services.AddTransient<IAdoptionStatusService, AdoptionStatusManager>();
builder.Services.AddTransient<IAdoptionStatusDal, EfAdoptionStatusDal>();

builder.Services.AddTransient<IGenusService, GenusManager>();
builder.Services.AddTransient<IGenusDal, EfGenusDal>();

builder.Services.AddTransient<ITypeeService, TypeeManager>();
builder.Services.AddTransient<ITypeeDal, EfTypeeDal>();

builder.Services.AddTransient<IAnimalService, AnimalManager>();
builder.Services.AddTransient<IAnimalDal, EfAnimalDal>();
#endregion
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
