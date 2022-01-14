using DefaultWebAPI.Services;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DefaultWebAPI.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DefaultWebAPIContext>(options =>


    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultWebAPIContext")));


// Add services to the container.

builder.Services.AddControllers()
    .AddXmlSerializerFormatters(); // XML wird zus�tzlich auch angeboten 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITimeService, TimeService>();
var app = builder.Build();

//DI Variante 3
using (IServiceScope scope = app.Services.CreateScope())
{
    ITimeService timeService = scope.ServiceProvider.GetRequiredService<ITimeService>();
    Debug.WriteLine(timeService.GetCurrentTime());
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Swagger wird ier nur f�r die Entwicklung angeboten -> Im PRoduction-Modus soll diese nicht verf�gbar sein
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
