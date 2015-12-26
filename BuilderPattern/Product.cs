using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class Product
    {
        string parts = string.Empty;

        public void Add(string part)
        {
            parts += part;
        }

        public void Show()
        {
            System.Console.WriteLine(parts);
        }
    }
}
