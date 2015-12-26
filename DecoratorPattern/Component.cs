using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    abstract class Component
    {
        public string msg = "original msg.";
        public void Show()
        {
            System.Console.WriteLine(msg);
        }
    }
}
