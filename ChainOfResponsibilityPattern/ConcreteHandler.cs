using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class ConcreteHandler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (Successor != null)
            {
                Console.WriteLine("放过请求");
                Successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("处理请求");
            }
        }
    }
}
