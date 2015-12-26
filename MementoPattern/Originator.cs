using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 发起人
    /// </summary>
    class Originator
    {
        public string State { get; set; }

        /// <summary>
        /// 创建备忘录，将当前需要保存的信息导入并实例化出一个Memento对象
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        /// <summary>
        /// 恢复备忘录，将Memento导入并将相关数据恢复
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State=" + State);
        }
    }
}
