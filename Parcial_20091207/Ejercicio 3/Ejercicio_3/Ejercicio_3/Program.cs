using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICache<string, string> cache = new LimitedCache<string, string>(3);

            cache.Add("hola", "mundo");
            cache.Add("soy", "laura");
            cache.Add("key", "value");

            Console.WriteLine(cache.Get("key"));
            Console.WriteLine(cache.Get("soy"));
            Console.WriteLine(cache.Get("soy"));

            cache.Add("K", "V");
            try
            {
                Console.WriteLine(cache.Get("hola"));
            }
            catch(NotFoundKeyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            cache.Add("72.33", "poo");

            try
            {
                Console.WriteLine(cache.Get("K"));
            }
            catch (NotFoundKeyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(cache.Get("72.33"));
            Console.WriteLine(cache.Get("72.33"));

            cache.Add("x", "y");

            try
            {
                Console.WriteLine(cache.Get("key"));
            }
            catch (NotFoundKeyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
