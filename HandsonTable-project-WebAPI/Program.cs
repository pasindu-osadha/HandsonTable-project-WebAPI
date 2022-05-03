using HandsonTable_project_WebAPI.Data;
using HandsonTable_project_WebAPI.Data.Interface;
using HandsonTable_project_WebAPI.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HandsonTableDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HansontableContext")));

builder.Services.AddScoped<IDataRepo, DataRepo>();

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
