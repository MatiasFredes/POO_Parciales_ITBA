using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class ArrayListFiltered<T> : List<T>, IFilterList<T>
    {
        public IFilterList<T> filter(ICriteria<T> criteria)
        {
            var result = new ArrayListFiltered<T>();
            foreach (T elem in this)
            {
                if (criteria.Satisfies(elem))
                {
                    result.Add(elem);
                }
            }

            return result;
        }
    }
}
