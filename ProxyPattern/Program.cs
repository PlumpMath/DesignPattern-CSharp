using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject proxy = new Proxy();
            proxy.Request();

            System.Console.ReadKey();
        }
    }
}
