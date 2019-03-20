using System.Collections;
using System.Collections.Generic;
using ObserverPattern.Subscribers;

namespace ObserverPattern.Observers
{
    public class Video : IObserver
    {
        IList<ISubscriber> _subscribers;
        public Video()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void Add(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Delete(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var item in _subscribers)
            {
                item.Update();
            }
        }

        public string GetStatus()
        {
            return $"New video has been added.";
        }
    }
}