using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /**
     将对象组合成树形结构以表示‘部分-整体’的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性
     */
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite compX = new Composite("Composite X");
            compX.Add(new Leaf("Leaf XA"));
            compX.Add(new Leaf("Leaf XB"));

            root.Add(compX);

            Composite compY = new Composite("Composite Y");
            compY.Add(new Leaf("Leaf YA"));
            compY.Add(new Leaf("Leaf YB"));

            compX.Add(compY);

            root.Show(1);

            Console.Read();
        }
    }
}
