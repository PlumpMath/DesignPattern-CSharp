using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    /**
     应用：数据库连接池，线程池
     */
    class Client
    {
        void Test()
        {
            // 外部状态
            int extrinsicState = 22;
            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicState);

            Flyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicState);
        }

        static void Main(string[] args)
        {
            new Client().Test();
            Console.ReadKey();
        }
    }
}
