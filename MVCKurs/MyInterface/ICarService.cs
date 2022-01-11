namespace MyInterface
{
    public interface ICarService
    {
        void Repair(ICar car);
        void Repair(ICarV2 car);
    }
}