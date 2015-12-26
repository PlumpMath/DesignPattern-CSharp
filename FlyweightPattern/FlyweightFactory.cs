using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyweightPattern
{
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
        }

        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights[key] = new ConcreteFlyweight();
            }
            return (Flyweight)flyweights[key];
        }
    }
}
