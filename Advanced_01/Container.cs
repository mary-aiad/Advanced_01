using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_01
{
    internal class Container <T>
    {
        private T value;

        
        public void Add(T item)
        {
            value = item;
        }

        public T Get()
        {
            return value;
        }
    }
}
