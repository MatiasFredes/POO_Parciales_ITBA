using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public interface ICache<K,V>
    {
        void Add(K key, V value);
        V Get(K key);

        int Size();
    }
}
