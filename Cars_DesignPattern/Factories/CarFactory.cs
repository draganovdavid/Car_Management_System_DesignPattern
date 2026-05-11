using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.Factories
{
    public abstract class CarFactory
    {
        public abstract ICar CreateCar();
    }
}
