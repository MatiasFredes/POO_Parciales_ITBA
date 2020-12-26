using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new IgnoreNullList<int?>();

            list.Add(1);
            list.Add(null);
            list.Add(2);
            list.Add(5);
            list.Add(null);
            list.Add(3);
            list.Add(null);

            IEnumerator<int?> enumerator = list.IgnoreNullsIterator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
