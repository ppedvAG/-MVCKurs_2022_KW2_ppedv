namespace MyInterface
{
    public interface ICar
    {
        public string Marke { get; set; };
        public string Modell { get; set; };
        public int Baujahr { get; set; }


        public bool HatTüv();
    }

    //Für IServiceCollection eine Detailunterscheidung
    public interface ICarSingleton : ICar
    {

    }

    public interface ICarScoped : ICar
    {

    }


    public interface ICarTransient : ICar
    {

    }


}