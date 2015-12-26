using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            new Client().Test();
            Console.ReadKey();
        }

        Receiver receiver;
        Command command;
        Invoker invoker;

        public void Test()
        {
            receiver = new Receiver();
            command = new ConcreteCommand(receiver);
            invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExcuteCommand();
        }
    }
}
