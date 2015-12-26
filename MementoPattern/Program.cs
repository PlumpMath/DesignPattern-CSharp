using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On"; // 初始化状态
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // 修改状态
            o.State = "Off";
            o.Show();

            // 恢复状态
            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
