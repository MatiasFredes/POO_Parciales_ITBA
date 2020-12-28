using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class MultiMap<K, V> : IMultiMap<K, V>
    {
        private IDictionary<K, IList<V>> multiMap;

        public MultiMap()
        {
            multiMap = new Dictionary<K,IList<V>>();
        }

        public ICollection<V> Get(K key)
        {
            if (multiMap.ContainsKey(key))
            {
                return multiMap[key];
            }
            else
                return null;
        }

        public void Put(K key, V value)
        {
            if (multiMap.ContainsKey(key))
            {
                multiMap[key].Add(value);
            }
            else
            {
                multiMap.Add(key, new List<V>() { value });
            }
        }

        public void Remove(K key, V value)
        {
            if (multiMap.ContainsKey(key))
            {
                multiMap[key].Remove(value);
            }
        }

        public void Remove(K key)
        {
            if (multiMap.ContainsKey(key))
            {
                multiMap[key].Clear();
            }
        }

        public int Size()
        {
            return multiMap.Count;
        }

        public void ShowElements()
        {
            foreach (var key in multiMap.Keys)
            {
                ICollection<V> list = Get(key);
                foreach (var value in list)
                {
                    Console.WriteLine($"{key} - {value}");
                }
            }
        }
    }
}
