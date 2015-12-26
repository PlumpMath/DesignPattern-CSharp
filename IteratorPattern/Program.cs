using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("1").Add("2").Add("3").Add("4");

            var eumerator = list.GetEumerator();
            while (eumerator.MoveNext())
            {
                Console.WriteLine(eumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
