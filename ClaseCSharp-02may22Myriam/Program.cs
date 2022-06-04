using System;

namespace ClaseCSharp_02may22Myriam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();

            string nombre;
            Console.WriteLine("Ingresá tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine($"Tu nombre es {nombre}");
            Console.WriteLine("Tu nombre es "+ nombre);

            int dividendo;
            int divisor; 
            Console.WriteLine("Ingresá el dividendo");
            dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el divisor");
            divisor = int.Parse(Console.ReadLine());
            Console.WriteLine($"La división da {dividendo/divisor}");

        }
    }
}
