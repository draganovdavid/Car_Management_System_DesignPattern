using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.Models
{
    public class BMW : ICar
    {
        public void ShowInfo()
        {
            Console.WriteLine("BWM created");
        }
    }
}