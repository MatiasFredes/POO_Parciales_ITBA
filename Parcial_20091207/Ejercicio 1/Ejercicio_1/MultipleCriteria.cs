using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    public class MultipleCriteria<T> : ICriteria<T>
    {
        IList<Func<T, bool>> criterias;

        public MultipleCriteria(IList<Func<T, bool>> criterias)
        {
            this.criterias = criterias;
        }

        public bool Satisfies(T obj)
        {
            foreach(var criteria in criterias)
            {
                if(!criteria(obj))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
