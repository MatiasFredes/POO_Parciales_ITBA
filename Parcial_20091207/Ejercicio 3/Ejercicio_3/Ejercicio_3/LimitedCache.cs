using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio_3
{
    class LimitedCache<K, V> : ICache<K, V>
    {
        private int capacity;
        private IDictionary<K, int> cacheHits;
        private IDictionary<K, V> cache;
        public LimitedCache(int capacity)
        {
            cache = new Dictionary<K, V>();
            cacheHits = new Dictionary<K, int>();
            this.capacity = capacity;
        }

        public void Add(K key, V value)
        {
            if(!cache.ContainsKey(key) && cache.Count < capacity)
            {
                AddElement(key, value);
            }
            else
            {
                if (capacity == cache.Count)
                {
                    var elementLeastUsed = cacheHits.OrderBy(elem => elem.Value).FirstOrDefault();
                    cache.Remove(elementLeastUsed.Key);
                    cacheHits.Remove(elementLeastUsed.Key);
                    AddElement(key, value);
                }
            }
        }

        private void AddElement(K key, V value)
        {
            cache.Add(key, value);
            cacheHits.Add(key, 0);
        }

        public V Get(K key)
        {
            if (cache.ContainsKey(key))
            {
                cacheHits[key] += 1;
                return cache[key];
            }
            throw new NotFoundKeyException("null");
        }

        public int Size()
        {
            return cache.Count;
        }
    }
}
