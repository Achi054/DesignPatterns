using System;
using ObserverPattern.Observers;
using ObserverPattern.Subscribers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern !");
            var videoObserver = new Video();
            var homeSubscriber = new HomeSubscriber(videoObserver);
            var workSubscriber = new WorkSubscriber(videoObserver);

            videoObserver.Add(homeSubscriber);
            videoObserver.Add(workSubscriber);

            videoObserver.Notify();
        }
    }
}
