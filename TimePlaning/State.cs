using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    public class Context
    {
        private Dictionary<String, int> data = new Dictionary<string, int>();
        public void Set(string key, int value)
        {
            if (data.ContainsKey(key))
            {
                data[key] = value;
            }
            else
            {
                data.Add(key, value);
            }
        }

        public int Get(string key)
        {
            return data[key];
        }
    }
}
