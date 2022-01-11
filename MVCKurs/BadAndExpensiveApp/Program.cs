// See https://aka.ms/new-console-template for more information
using BadCarService;
using MyBadCar;

CarService carService = new();

Car car = new Car();
car.Marke = "VW";
car.Modell = "POLO";
car.Baujahr = 2011;

carService.Repair(car);