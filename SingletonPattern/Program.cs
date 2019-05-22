using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the only object available
            var logger = SingletonPattern.LazyLoadedLogger.GetInstance();

            //show the message
            logger.showMessage();
        }
    }
}
