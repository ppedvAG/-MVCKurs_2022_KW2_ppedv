using GoodCarService;
using MVCSamples.Data;
using MyInterface;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//WebApplicationBuilder ist für verantwortlich für das hinzufügen von Diensten / Objekte in die ServiceCollection

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddSingleton<ICarServiceSingleton, CarService>();
builder.Services.AddScoped<ICarServiceScoped, CarService>();
builder.Services.AddTransient<ICarServiceTrransient, CarService>();

builder.Services.AddSingleton<ICarSingleton, MockCar>();
builder.Services.AddScoped<ICarScoped, MockCar>();
builder.Services.AddTransient<ICarTransient, MockCar>();
builder.Services.AddDbContext<MovieDbContext>();

//Ab Build kann ServiceCollectio nicht mehr erweitert werden. 
//Danach können wir auf Service Collection zugreifen 
var app = builder.Build();


//Frühste Möglichkeit auf den IOC Container zu zugreifen 
using (IServiceScope scope = app.Services.CreateScope())
{
    ICarServiceScoped result = scope.ServiceProvider.GetRequiredService<ICarServiceScoped>();
    result.Repair(new MockCar());
}

//Variante 1 direktes auslesen via IServiceProvider

//ICarService myService = app.Services.GetRequiredService<ICarServiceScoped>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



Console.ReadKey();

