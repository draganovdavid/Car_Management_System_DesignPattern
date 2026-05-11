using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.Models
{
    public class Peugeot : ICar
    {
        public void ShowInfo()
        {
            Console.WriteLine("Peugeot created");
        }
    }
}