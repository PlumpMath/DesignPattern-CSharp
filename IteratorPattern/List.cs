using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    class List<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public int Capacity { get { return array.Count(); } }

        public IEumerator<T> GetEumerator()
        {
            if (eumerator == null)
            {
                eumerator = new ListEumerator<T>(this);
            }
            eumerator.Reset();
            return eumerator;
        }

        private T[] array = new T[8];
        private IEumerator<T> eumerator;

        public T this[int index]
        {
            get
            {
                if (index >= this.Capacity)
                    throw new Exception("索引不在有效范围内.");
                return array[index];
            }
            set
            {
                if (index >= this.Capacity)
                    throw new Exception("索引不在有效范围内.");
                array[index]  =value;
            }
        }

        public List<T> Add(T item)
        {
            if (Count >= Capacity)
                throw new Exception("Memory overflow.");
            array[Count] = item;
            ++Count;
            return this;
        }

        class ListEumerator<T> : IEumerator<T>
        {
            List<T> list;
            public ListEumerator(List<T> list)
            {
                this.list = list;
            }

            public T Current
            {
                get { return list[currentIndex]; }
            }

            private int currentIndex;

            public bool MoveNext()
            {
                ++currentIndex;
                return currentIndex < list.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
