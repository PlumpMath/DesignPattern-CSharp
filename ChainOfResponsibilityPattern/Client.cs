using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Client
    {
        Handler handler1;
        Handler handler2;

        void Test()
        {
            //组装责任链
            handler1 = new ConcreteHandler();
            handler2 = new ConcreteHandler();
            handler1.Successor = handler2;

            //提交请求
            handler1.HandleRequest(0);
        }

        static void Main(string[] args)
        {
            new Client().Test();
            Console.ReadKey();
        }
    }
}
