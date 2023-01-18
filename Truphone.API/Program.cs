using Microsoft.EntityFrameworkCore;
using Truphone.Application;
using Truphone.Application.Interfaces;
using Truphone.Infrastructure;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITruphoneRepository, TruphoneRepository>();
builder.Services.AddScoped<ITruphoneService, TruphoneService>();



var cs = builder.Configuration.GetConnectionString("TruphoneContext");
builder.Services.AddDbContext<TruphoneContext>(options =>
                                        options.UseSqlServer(cs, o =>
                                        {
                                            o.CommandTimeout(5000);
                                            o.EnableRetryOnFailure();
                                            
                                        }), ServiceLifetime.Transient);

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
