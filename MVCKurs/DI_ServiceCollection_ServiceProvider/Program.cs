using Microsoft.Extensions.DependencyInjection;


//Die ServiceCollection sammelt alle Dienste, Objekte zusammen.
IServiceCollection serviceCollection = new ServiceCollection();

//Die Objekte werden mithilfe Singleton / Scope / Transient (Lebenszyklen von Objekten) eingebunden.
serviceCollection.AddSingleton<IMyDependeny, MyDependeny>(); //Instanz wird erstellt
//weitere Klassen hinzufügen 


//Wenn wir fertig mit Hinzufügen von Services oder Klassen:
//IOC Container ist fertig augebaut und wird als IServiceProvider verwendet 
IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

//Wenn IMyDependeny nicht gefunden wird -> GetRequiredService schmeisst eine Exception
IMyDependeny myDependeny = serviceProvider.GetRequiredService<IMyDependeny>();
//Wenn IMyDependeny nicht gefunden wird -> GetService gibt NULL zurück
IMyDependeny? myDependeny1 = serviceProvider.GetService<IMyDependeny>();



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