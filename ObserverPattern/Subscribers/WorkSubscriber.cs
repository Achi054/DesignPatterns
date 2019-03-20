using ObserverPattern.Observers;

namespace ObserverPattern.Subscribers
{
    public class WorkSubscriber : ISubscriber
    {
        IObserver _observer;
        public WorkSubscriber(IObserver observer)
        {
            _observer = observer;
        }
        public void Update()
        {
            System.Console.WriteLine($"Work subscriber, {this._observer.GetStatus()}");
        }
    }
}