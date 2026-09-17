using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_01
{
    internal class SafeList<T>
    {
        private List<T> _list = new List<T>();
        public void Add(T item)
        {
            _list.Add(item);
        }

        public T Get(int index)
        {
            if(index > 0 && _list.Count > index)
                return _list[index];
            return default;
        }
    }
}
