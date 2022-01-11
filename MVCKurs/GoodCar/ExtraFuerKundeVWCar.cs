using MyInterface;

public class VWCar : ICar
{
    public string Marke { get; set; } = default!;
    public string Modell { get; set; } = default!;
    public int Baujahr { get; set; }

    public bool HatTüv()
    {
        //eine Pseudo Logik

        if (Baujahr < 1990)
            return false;
        else
            return true; 

    }
}