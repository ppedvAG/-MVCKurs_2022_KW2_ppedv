using Microsoft.Extensions.DependencyInjection;
using MyInterface;


//Die ServiceCollection sammelt alle Dienste, Objekte zusammen.
IServiceCollection serviceCollection = new ServiceCollection();


//serviceCollection.AddDbContext(/*Parameter etc*/);


//Die Objekte werden mithilfe Singleton / Scope / Transient (Lebenszyklen von Objekten) eingebunden.
serviceCollection.AddSingleton<IMyDependeny, MyDependeny>(); //Instanz wird erstellt
serviceCollection.AddScoped<IMyDependeny, MyDependeny>();
serviceCollection.AddTransient<IMyDependeny, MyDependeny>();


serviceCollection.AddScoped<ICar, Car>();
serviceCollection.AddSingleton<ICar, MockCar>(); //Instanz wird erstellt
//serviceCollection.AddTransient<ICar, MockCar>();

//LifeCylpe -> Wann wird ein Objekt neu aufgebaut (Instanziiert). 

//Singleton -> Objekt wird nur einmal aufgebaut und lebt solange die Web-Anwendung läuft 
//Use Case -> komplexe Objekte, die eine lange Initialisierszeit benötigen -> diese wären als Singleton gut geeignet
//            !!! Vorsicht -> Das Objekt wird nur einmal Instanziiert und sollte nach Wochen noch einen validen Stand


//Scope -> Wird pro Request einmal instanziiert! Request bedeutet der Browser (URL) steuert eine Seite auf dem WebServer an.
//Der WebServer will die Seite aufbereiten (dieser Vorgang ist die Request - Scope). Beispiel DBContext. Pro Instanziierung kann EFCore die aktuellsten Daten auslesen. 

//Transient -> Pro Request und wenn es jedesmal verwendet wird



//weitere Klassen hinzufügen 


//Wenn wir fertig mit Hinzufügen von Services oder Klassen:
//IOC Container ist fertig augebaut und wird als IServiceProvider verwendet 
IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

//Wenn IMyDependeny nicht gefunden wird -> GetRequiredService schmeisst eine Exception
IMyDependeny myDependeny = serviceProvider.GetRequiredService<IMyDependeny>();
//Wenn IMyDependeny nicht gefunden wird -> GetService gibt NULL zurück
IMyDependeny? myDependeny1 = serviceProvider.GetService<IMyDependeny>();




ICar? whichCar = serviceProvider.GetService<ICar>();

interface IMyDependeny
{
    void WriteMessage(string msg);
}

public class MyDependeny : IMyDependeny
{
    public void WriteMessage(string msg)
    {
        Console.WriteLine($"MyDependency.WriteMessage Message: {msg}");
    }
}