namespace MyInterface
{
    public interface ICarService
    {
        void Repair(ICar car);
        void Repair(ICarV2 car);
    }

    public interface ICarServiceSingleton : ICarService
    {
        //Aliase
    }

    public interface ICarServiceScoped : ICarService
    {

    }

    public interface ICarServiceTrransient : ICarService
    {

    }
}