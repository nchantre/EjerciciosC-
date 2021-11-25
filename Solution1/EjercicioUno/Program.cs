using System;

namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int con = 10;
            int contador = 1;
            Console.WriteLine("Ingresar Primer dato");
            int dato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar Segundo dato");
            int datodos = Convert.ToInt32(Console.ReadLine());
            if (dato>datodos)
            {
                Console.WriteLine("el primero es menor");

            }
            else
            {
                Console.WriteLine("El segundo es mayor");
            }

            for (int i = 1; i <= con; i++)
            {
                Console.WriteLine(dato+"X"+i+"="+dato*i);

            }
            Console.WriteLine("############################");
            while (contador<=con)
            {
                Console.WriteLine(dato + "X" + contador + "=" + dato * contador);
                contador++;
            }


            int resultado = dato + datodos;


            Console.WriteLine("El resultado de la Operacion :" +resultado);
            Console.ReadKey();
        }
    }
}
