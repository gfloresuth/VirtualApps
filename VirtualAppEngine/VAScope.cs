using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualAppEngine
{
    class VAScope
    {
        private Dictionary<string, object> _values;
        public void setValue(string name, object value)
        {
            if (existsValue(name)==false)
            {
                _values.Add(name, value);
            }else
            {
                _values[name] = value;
            }
        }
        public object getValue(string name)
        {
            return (existsValue(name) == true) ? _values[name] : null;
        }
        public Boolean existsValue(string name)
        {
            return _values.ContainsKey(name);
        }
    }
}
