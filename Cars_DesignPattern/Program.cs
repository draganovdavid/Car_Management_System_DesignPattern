using Cars_DesignPattern.Factories;
using Cars_DesignPattern.GPS_Models;
using Cars_DesignPattern.Interfaces;
using Cars_DesignPattern.ObserverModels;

namespace Cars_DesignPattern
{
    internal class Program
    {
        static void Main()
        {
            CarFactory factory = new BMWFactory();
            ICar car = factory.CreateCar();
            car.ShowInfo();

            OldGPS oldGPS = new OldGPS();
            IGPS gps = new GPSAdapter(oldGPS);
            gps.Navigate();

            CarMarket market = new CarMarket();

            Customer customer1 = new Customer("David");
            Customer customer2 = new Customer("Veselin");

            market.Subscribe(customer1);
            market.Subscribe(customer2);

            market.Notify("BMW price decreased!");
        }
    }
}