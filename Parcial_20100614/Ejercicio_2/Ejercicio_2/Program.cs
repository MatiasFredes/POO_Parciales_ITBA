using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var paisProvincia = new MultiMap<string, string>();

            paisProvincia.Put("Argentina", "Buenos Aires");
            paisProvincia.Put("Argentina", "CABA");
            paisProvincia.Put("Argentina", "Cordoba");
            paisProvincia.Put("Argentina", "Santa Fe");

            paisProvincia.Put("Uruguay", "Maldonado");
            paisProvincia.Put("Uruguay", "Canelones");
            paisProvincia.Put("Uruguay", "Montevideo");
            paisProvincia.Put("Uruguay", "Durazno");

            paisProvincia.Put("Brasil", "Sao Paulo");
            paisProvincia.Put("Brasil", "Rio de Janeiro");
            paisProvincia.Put("Brasil", "Mato Grosso");
            paisProvincia.Put("Brasil", "Amazonas");

            paisProvincia.Recorrer();
            paisProvincia.Remove("Argentina", "CABA");
            paisProvincia.Recorrer();

        }
    }
}
