namespace SingletonPattern
{   
    public class LazyLoadedLogger
    {
        private static LazyLoadedLogger logger;
        
        private LazyLoadedLogger() { }

        //Lazy Loading
        public static LazyLoadedLogger GetInstance()
        {
            if(logger == null)
                logger = new LazyLoadedLogger();
            return logger;
        }

        public void showMessage()
        {
            System.Console.WriteLine("Hello World!");
        }
    }

    public class EagerLoadedLogger
    {
        private static EagerLoadedLogger logger = new EagerLoadedLogger();
        
        private EagerLoadedLogger() { }

        //Eager Loading
        public static EagerLoadedLogger GetInstance()
        {
            return logger;
        }

        public void showMessage()
        {
            System.Console.WriteLine("Hello World!");
        }
    }

    public class ThreadSafeLogger
    {
        private static ThreadSafeLogger logger;
        private static object obj;
        
        private ThreadSafeLogger() { }

        //Thread safe
        public static ThreadSafeLogger GetInstance()
        {
            lock (obj)
            {
                if(logger == null)
                    logger = new ThreadSafeLogger();
            }
            return logger;
        }

        public void showMessage()
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}