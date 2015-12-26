using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        /**
            一个对象作为原型，对其进行复制、克隆，产生一个和原对象类似的新对象。
         */
        static void Main(string[] args)
        {
            var p1 = new Prototype("p1", 20, 30);
            var p2 = (Prototype)p1.Clone();

            p2.Shape.Height = 40;

            p1.Show();
            p2.Show();

            System.Console.ReadKey();
        }
    }
}
