namespace MyInterface
{
    public interface ICar
    {
        public string Marke { get; set; };
        public string Modell { get; set; };
        public int Baujahr { get; set; }


        public bool HatTüv();
    }
}