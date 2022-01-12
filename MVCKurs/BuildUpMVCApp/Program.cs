var builder = WebApplication.CreateBuilder(args);

//Wir sagen ASPNETCore, dass wir eine MVC App verwendet. 
builder.Services.AddControllersWithViews();
//AddControllersWithViews -> Hier werden auch weitere Dienste (Services) im  Hintergrund hinzugefügt

var app = builder.Build();


//Was ist IsDeveloment / IsStaging / Is Production ?
//An Beispiel IsDevelopment -> WebApp + WebServer für Entwicklung 



//Konfigurieren die Dienste im IOC Containre

//Im Produktiven Modus, soll eine formatiere Fehlerseite dargestellt werden app.UseExceptionHandler("/Home/Error"); 
//UND die Sicherheitsstandard werden hochgesetzt -> app.UseHsts();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); //Von Https ein Sicherheitsaufsatz
}

//warum kan ich nicht auf wwwRoot zugreifen? 
app.UseHttpsRedirection(); // Https kann verwendet werden -> ansonsten nur Http
app.UseStaticFiles(); //Zugriff auf wwwRoot

app.UseRouting(); //Navigation -> Controller + Action-Methoden verweisen können

app.UseAuthorization();

app.MapGet("/Textausgabe", async context =>
{
    await context.Response.WriteAsync("Hello World!");
});

//Request werden nach dem MVC Muster verarbeitet -> Bedeutet -> Request wird zu Controller und Action-Methode geleitet 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//https://localhost:12345/Home -> https://localhost:12345/Home/Index

app.Run();
