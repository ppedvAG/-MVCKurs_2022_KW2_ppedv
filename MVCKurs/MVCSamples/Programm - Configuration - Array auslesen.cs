//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.Configure<PositionOptions>(
//    builder.Configuration.GetSection(PositionOptions.Position));


////Einlesen unserer weiteren Array.json Konfigurationsdatei 
//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//    config.AddJsonFile("MyArray.json", true, true);
//});



////2 Schritt -> Typisierte Auslesen (IOption-Pattern) 
//builder.Services.Configure<ArrayExample>(
//    builder.Configuration.GetSection("array"));


//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
