using MyInterface;

namespace GoodCarService
{
    public class CarService : ICarServiceSingleton, ICarServiceScoped, ICarServiceTrransient // ICarService auch findbar,
    {
        public void Repair(ICar car)
        {
            if (car.HatTüv())
            {
                Console.WriteLine(car.Marke + " " + car.Modell + " wird repariert");
            }
            else
                Console.WriteLine(car.Marke + " " + car.Modell + " wird länger repariert -> Grund: Kein Tüv");


        }

        public void Repair(ICarV2 car)
        {
           //Varianten 1 -> rufen alten Code auf
            Repair(car);

            //und erweitern diesen 
           
        }
    }
}