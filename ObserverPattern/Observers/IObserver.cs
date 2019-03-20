using ObserverPattern.Subscribers;

namespace ObserverPattern.Observers
{
    public interface IObserver
    {
        void Add(ISubscriber subscriber);
        void Delete(ISubscriber subscriber);
        void Notify();
        string GetStatus();
    }
}