using System.Text;

namespace Ejercicio_1
{
    /// <summary>
    /// Modela un criterio a aplicar a un objeto de tipo T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICriteria<T>
    {
        bool Satisfies(T obj);
    }
}
