using System;
using ProxyPattern.ExternalComponent;
using ProxyPattern.ProxyComponent;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern");

            var proxyParser = new BookParserProxy("Book.pdf");
            proxyParser.Display();
            System.Console.WriteLine("Second call");
            proxyParser.Display();

            System.Console.ReadLine();
        }
    }
}
