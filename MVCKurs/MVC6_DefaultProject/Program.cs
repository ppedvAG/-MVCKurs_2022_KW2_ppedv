var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddControllersWithViews();
//AddControllerWithViews: 
//Benötigen wird folgende Ordnerstrukturen -> Controller-Verzeichnis, View-Verzeichnis, Model + wwwRoot

var app = builder.Build(); 


// Configure the HTTP request pipeline. //Startup -> Configure 
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


//MVC Middleware - Ich nehme das Request, schaue welche Controller-Klasse und Action-Methode angesprochen werden soll
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapRazorPages(); //Middleware für RazorPages 
//app.MapControllers(); //Reuquest wird von WebAPI MVC-Middleware zu der jeweiligen Controller->Action MEthode geleitet 
//app.UseMvc(); -> alternativ kann man MapControllerRoute + MapRazorPages() verwenden. 
app.Run();
