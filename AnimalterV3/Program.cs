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
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region ServiceAndRepoRegister

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

builder.Services.AddTransient<IUserService, UserManager>();
builder.Services.AddTransient<IUserDal, EfUserDal>();

builder.Services.AddTransient<IRoleService, RoleManager>();
builder.Services.AddTransient<IRoleDal, EfRoleDal>();

builder.Services.AddTransient<IImageService, ImageManager>();
builder.Services.AddTransient<IImageDal, EfImageDal>();

builder.Services.AddTransient<IPetOwnerService, PetOwnerManager>();
builder.Services.AddTransient<IPetOwnerDal, EfPetOwner>();

builder.Services.AddTransient<IUserRoleDal, EfUserRoleDal>();
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(o =>
{
    o.AllowAnyHeader();
    o.AllowAnyMethod();
    o.AllowAnyOrigin();
});
app.UseAuthorization();

app.MapControllers();

app.Run();
