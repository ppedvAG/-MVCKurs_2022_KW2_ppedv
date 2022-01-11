using MyInterface;

public class Car : ICarSingleton, ICarTransient, ICarScoped
{
    public string Marke { get; set; } = default!;
    public string Modell { get; set; } = default!;
    public int Baujahr { get; set; }

    public bool HatTüv()
    {
        //eine Pseudo Logik

        if (Baujahr < 2000)
            return false;
        else
            return true; 

    }
}