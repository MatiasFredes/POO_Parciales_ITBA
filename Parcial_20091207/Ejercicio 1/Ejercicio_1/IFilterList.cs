using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    /// <summary>
    /// Modela una lista que puede ser filtrada según un criterio
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFilterList<T> : IList<T>
    {
        public IFilterList<T> filter(ICriteria<T> criteria);
    }
}
