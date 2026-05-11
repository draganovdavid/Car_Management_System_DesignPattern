using Cars_DesignPattern.Interfaces;
using Cars_DesignPattern.Models;

namespace Cars_DesignPattern.Factories
{
    public class Mercedes_BenzFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Mercedes_Benz();
        }
    }
}
