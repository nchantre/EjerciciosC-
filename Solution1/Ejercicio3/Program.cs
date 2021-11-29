using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string datoregistro = "23";
            int dto = 23;
            // transformacion de string a int

            int dato = Int32.Parse(datoregistro);

            string resultado = dto + datoregistro;

            int rt = dto + dato;
            Console.WriteLine("resultado es :" + resultado);
            Console.WriteLine("****************************");
            Console.WriteLine("resultado de la suma es :" + rt);
            Console.ReadKey();

        }
    }
}
