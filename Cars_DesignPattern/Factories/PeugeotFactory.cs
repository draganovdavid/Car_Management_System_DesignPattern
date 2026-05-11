using Cars_DesignPattern.Interfaces;
using Cars_DesignPattern.Models;

namespace Cars_DesignPattern.Factories
{
    public class PeugeotFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Peugeot();
        }
    }
}