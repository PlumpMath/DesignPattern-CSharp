using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Prototype : ICloneable
    {
        public string Name { get; set; }
        public Shape Shape { get; set; }

        public Prototype(string name, double width, double height)
        {
            this.Name = name;
            Shape = new Shape(width, height);
        }

        public void Show()
        {
            System.Console.WriteLine("{0}:{1} X {2}", Name, Shape.Width, Shape.Height);
        }

        public object Clone()
        {
            // 潜复制
            var obj = (Prototype)this.MemberwiseClone();
            // 深复制
            obj.Shape = (Shape)this.Shape.Clone();
            return obj;
        }
    }
}
