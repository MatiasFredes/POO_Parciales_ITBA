using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class IgnoreNullList<T> : List<T>
    {
        private IEnumerable<T> GetValues()
        {
            foreach (var item in this)
            {
                if(item != null)
                {
                    yield return item;
                }
            }
        }
        public IEnumerator<T> IgnoreNullsIterator()
        {
            return this.GetValues().GetEnumerator();
        }

       
    }
}
