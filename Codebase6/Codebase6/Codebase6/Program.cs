﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Codebase6.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Codebase6Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Codebase6Context") ?? throw new InvalidOperationException("Connection string 'Codebase6Context' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();