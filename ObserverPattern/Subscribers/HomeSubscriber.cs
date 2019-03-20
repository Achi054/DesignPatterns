using ObserverPattern.Observers;

namespace ObserverPattern.Subscribers
{
    public class HomeSubscriber : ISubscriber
    {
        IObserver _observer;
        public HomeSubscriber(IObserver observer)
        {
            _observer = observer;
        }
        public void Update()
        {
            System.Console.WriteLine($"Home subscriber, {this._observer.GetStatus()}");
        }
    }
}