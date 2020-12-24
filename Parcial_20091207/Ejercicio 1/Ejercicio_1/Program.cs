using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFilterList<int> list = new ArrayListFiltered<int>();
            list.Add(4);
            list.Add(3);
            list.Add(15);
            list.Add(16);
            list.Add(20);

            IList<Func<int, bool>> filters = new List<Func<int, bool>>()
            {
                isEven,
                IsTwoDigits
            };
           
            var criteria = new MultipleCriteria<int>(filters);
            var result = list.filter(criteria);

            // return 16 and 20
            foreach(var number in result)
            {
                Console.WriteLine(number);
            }
        }

        private static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsTwoDigits(int number)
        {
            return number > 9 && number < 100;
        }
    }
}
