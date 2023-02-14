using Employee.Core.Options;
using Employee.DataAccess.Employee;
using Employee.Repository.Employee;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ConnectionStringOptions>(builder.Configuration.GetSection(ConnectionStringOptions.ConnectionString));

// Add services to the container.
var x = AppDomain.CurrentDomain.GetAssemblies().ToArray();
builder.Services.AddMediatR(x);
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeDataAccess, EmployeeDataAccess>();


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
