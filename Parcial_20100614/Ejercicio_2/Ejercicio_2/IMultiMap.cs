using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public interface IMultiMap<K,V>
    {
        /// <summary>
        /// Asocia la clave key con el objeto value
        /// </summary>
        /// <param name="key">Calve</param>
        /// <param name="value">Valor asociado</param>
        void Put(K key, V value);

        /// <summary>
        /// Obtiene todos los objetos asociados a la clave key
        /// </summary>
        /// <param name="key">Clave buscada</param>
        /// <returns>La colección de objetos o null si la clave no existe</returns>
        ICollection<V> Get(K key);

        /// <summary>
        /// Devuelve el tamaño de la coleccion
        /// </summary>
        /// <returns></returns>
        int Size();

        /// <summary>
        /// Elimina la asociacion entre key y value. Si no existe la asociación no hace nada
        /// </summary>
        /// <param name="key">Clave buscada</param>
        /// <param name="value">Valor asociado</param>
        void Remove(K key, V value);

        /// <summary>
        /// Elimina todas las asociaciones con clave key
        /// </summary>
        /// <param name="key"></param>
        void Remove(K key);

        /// <summary>
        /// Muestra las claves y sus respectivas asociaciones
        /// </summary>
        void ShowElements();
    }
}
