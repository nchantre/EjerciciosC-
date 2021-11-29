using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la tabla de multiplicar");
            int dato = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(dato +"X"+i+"="+dato*i);
            }
            Console.ReadKey();
        }
    }
}
