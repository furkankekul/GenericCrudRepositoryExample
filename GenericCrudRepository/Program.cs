using DataAccessBase;
using DataAccessBase.EntityDataAccessors;
using DataAccessBase.GenericDataAccessRepos;
using Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Customer>, CustomerDataAcessor>();
builder.Services.AddScoped<IRepository<Product>, ProductDataAccessor>();


builder.Services.AddDbContext<ExampleDbContext>(options =>
    options.UseMySql("server=localhost;database=exampledb;user=root;password=root", new MySqlServerVersion(new Version(9, 2, 0))
);

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
