using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SecureTrade.BusinessLogic.Configurations;
using SecureTrade.DataAccess.Context;
using SecureTrade.DataAccess.Seed;
using SecureTrade.Domain.Entities;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbConfig(builder.Configuration);
builder.Services.AddServices();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.ConfigureMailing(builder.Configuration);
builder.Services.ConfigureSwaggerAndBearer(builder.Configuration);


builder.Services.Configure<DataProtectionTokenProviderOptions>(opts => opts.TokenLifespan = TimeSpan.FromMinutes(5));







var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Secure Trade v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//SEED 

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
var dbContext = services.GetRequiredService<MyAppContext>();
await Seeder.Seed(roleManager, userManager, dbContext);

app.Run();
