using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    public static class DictionaryExtensions
    {
        public static TV GetOrDefault<TK,TV>(this Dictionary<TK,TV> dic,TK key,TV defalutValue = default(TV))
        {
            TV result;
            return dic.TryGetValue(key, out result) ? result : defalutValue;
        }
    }
}
