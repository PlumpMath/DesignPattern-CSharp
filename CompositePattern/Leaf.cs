using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 没有分支的叶节点
    /// </summary>
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        { }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
