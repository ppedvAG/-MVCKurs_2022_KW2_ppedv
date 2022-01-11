namespace MyBadCar
{
    //Wenn Car Objekt verwendet wird, muss ALLEs getestet werden, bei dem Car-Objekt verwendet wird. 
    public class Car 
    {
        public string Marke { get; set; } = default!;
        public string Modell { get; set; } = default!;  
        public int Baujahr { get; set; }  
        
        //ich erweitere die Klasse und schaue was passiert :-)
        //(in 20 Minuten werde andere Programmierer dich ansprechen und fragen, warum deren Code nicht mehr funktioniert (Wechselwirkungen der Objekte, durch Feste Kopplint)) 

    }

    //Welche flexible Freiheiten kann ich mit Car noch erlangen? (wenige)
    //Unsinn Beispiel Teil 2 
    public class CarV2 : Car
    {
        //hier fängt der Unsinn an. 
    }
}