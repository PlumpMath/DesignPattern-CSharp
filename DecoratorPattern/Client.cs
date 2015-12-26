using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Client
    {
        /*
            装饰者模式：
            Component：定义ConcreteComponent和Decorator类要实现的方法，简单来说如果一个类继承于该类就具有装饰或被装饰能力。 
            ConcreteComponent：让Decorator对象为自己添加功能。有时候使用ConcreteComponent的派生类提供核心功能，在这种情况就是用ConcreteComponent替代了Component的功能，而且装饰者是继承于ConcreteComponent的子类。
            Decorator：具有特定装饰功能的类，用来装饰ConcreteComponent类。
         */
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            component = new DecoratorA(component);
            component = new DecoratorB(component);

            component.Show();

            System.Console.ReadKey();
        }
    }
}
