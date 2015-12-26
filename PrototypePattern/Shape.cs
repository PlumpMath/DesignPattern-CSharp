using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Shape : ICloneable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
