using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    /**
     意图：

        将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。

    适用性：

        当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时。

        当构造过程必须允许被构造的对象有不同的表示时。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Builder b1 = new ConcreteBuilder();
            Director d = new Director(b1);

            d.Construct();

            b1.GetResult().Show();

            Console.ReadKey();
        }
    }
}
