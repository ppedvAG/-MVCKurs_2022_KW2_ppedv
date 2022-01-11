using MyInterface;

public class MockCar : ICarSingleton, ICarScoped, ICarTransient
{
    public string Marke { get; set; } = "VW";
    public string Modell { get; set; } = "Polo";
    public int Baujahr { get; set; } = 2004;

    public bool HatTüv()
    {
        return false;
    }
}