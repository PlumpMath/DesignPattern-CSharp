using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 有分支的节点
    /// </summary>
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var c in children)
            {
                c.Show(depth + 2);
            }
        }
    }
}
