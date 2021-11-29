using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("****************");
            Console.WriteLine("Digite la edad");
            edad =  Int32.Parse(Console.ReadLine());

            if (edad>= 18)
            {
                Console.WriteLine(" es mayor de Edad");

            }
            else
            {
                Console.WriteLine("es Menor de Edad");
            }

  
            Console.ReadKey();
        }
    }
}
