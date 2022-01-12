//WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Main Methode 


//// Add services to the container.
//// Hinzufügen von Diensten in den IServiceCollection 
//builder.Services.AddControllersWithViews(); //startup -> ConfigureServices (AddABC)

////builder.Services.AddRazorPages(); //Razor Page UI 
////builder.Services.AddControllers(); //Web API - Kleine Bruder von MVC 
////builder.Services.AddMvc(); // Add MVC + Raroz Pages

//var app = builder.Build(); //Collection wird zum ServiceProvider (im Hintergrund) 


//// Configure the HTTP request pipeline. //Startup -> Configure 
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


////MVC Middleware - Ich nehme das Request, schaue welche Controller-Klasse und Action-Methode angesprochen werden soll
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.MapRazorPages(); //Middleware für RazorPages 
////app.MapControllers(); //Reuquest wird von WebAPI MVC-Middleware zu der jeweiligen Controller->Action MEthode geleitet 
////app.UseMvc(); -> alternativ kann man MapControllerRoute + MapRazorPages() verwenden. 
//app.Run();
