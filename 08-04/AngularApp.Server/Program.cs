using AngularApp.Server.DataService;
using AngularApp.Server.IDataService;
using AngularApp.Server.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));

builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddCors(

    options => options.AddPolicy(
        "Develop", options =>
        {
            options.AllowAnyHeader();
            options.AllowAnyMethod();
            options.AllowAnyOrigin();
        }

        )
   );


var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("Develop");
app.MapFallbackToFile("/index.html");

app.Run();
