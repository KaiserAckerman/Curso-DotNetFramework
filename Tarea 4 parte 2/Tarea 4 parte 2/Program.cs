using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule los números primos que existen entre el 1 y el 100
            int numero, divisor, numdivisores = 0;

            for (numero = 2; numero <= 100; numero++)
            {
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        numdivisores += 1;
                    }
                }

                if (numdivisores <= 2)
                {
                    Console.WriteLine(numero);
                }

                numdivisores = 0;
            }
            Console.ReadKey();
        }
    }
}
