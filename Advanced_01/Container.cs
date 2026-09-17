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

        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public T FindMax<T>(T x , T y) where T : IComparable 
        {
            return x.CompareTo(y) > 0 ?x : y;
        }
    }
}
