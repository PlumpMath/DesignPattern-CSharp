using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /*
        代理模式与策略模式区别：
        1. 代理与代理对象具有相同的接口。
        2. 策略中的容器与内部策略只是简单的组合关系，容器只是将内部策略的行为抽取出来，进行了统一的实现。
     */
    class Proxy : ISubject
    {
        ISubject subject;

        public Proxy()
        {
            // 产生代理对象
            subject = new RealSubject();
        }

        public void Request()
        {
            subject.Request();
        }
    }
}
