using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_01
{
    internal class Cashe<Tkey, Tvalue>
    {
        Dictionary<Tkey, Tvalue> dict = new Dictionary<Tkey, Tvalue>();   
        //public Tvalue Value { get; set; }
        public void Add(Tkey key, Tvalue value)
        {
            dict.Add(key, value);
        }

        public Tvalue Get(Tkey key)
        {
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }
            else
                return default;
        }

        public void Remove(Tkey key) 
        {
            dict.Remove(key);
        }

        public bool Contains(Tkey key)
        {
            return dict.ContainsKey(key);
        }

    }
}
