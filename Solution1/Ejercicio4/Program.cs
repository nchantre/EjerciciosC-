using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables 
            int dt1, dt2;
            Console.WriteLine("registro del primer numero");
            dt1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Registro del primer numero");
            dt2 = Int32.Parse(Console.ReadLine());
            int resultado = dt1 + dt2;
            Console.WriteLine("la suma es  : "+resultado);
            Console.ReadKey();
        }
    }
}
