using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.Models
{
    public class Mercedes_Benz : ICar
    {
        public void ShowInfo()
        {
            Console.WriteLine("Mercedes-Benz created");
        }
    }
}