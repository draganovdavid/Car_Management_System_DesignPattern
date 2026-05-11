using Cars_DesignPattern.Interfaces;


namespace Cars_DesignPattern.ObserverModels
{
    public class CarMarket
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}