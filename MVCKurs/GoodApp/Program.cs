using GoodCar;
using GoodCarService;
using MyInterface;

ICarService carService = new CarService();

carService.Repair(new MockCar()); //VW Polo wird als Testobjekt verwendet

//Wenn der Test sauber verlaufen ist 

ICar myCar = new Car();
myCar.Marke = "Porsche";
myCar.Modell = "944";
myCar.Baujahr = 2011;

carService.Repair(myCar); //VW Polo wird als Testobjekt verwendet


ICarV2 newCar = new CarV2();
newCar.Marke = "Porsche";
newCar.Modell = "944";
newCar.Baujahr = 2011;
newCar.Farbe = "blau";
newCar.AnhängerKupplung = true;


//In Methode Repair werden nur die Eigenschaften unterstützt, die ICar beinhalten
carService.Repair(newCar); //Abwärtskompatibel 



