using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.ObserverModels
{
    public class Customer : IObserver
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine(Name + " received: " + message);
        }
    }
}