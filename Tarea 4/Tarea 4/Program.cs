using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.

            int numbase, potencia, i;
            double resultadoneg, resultado;
            resultado = 1;
            

            Console.Write("Introduce el numero base: ");
            numbase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            if (potencia >= 1)
            {
                for (i = 1; i <= potencia ; i++)
                {
                    resultado *= numbase;
                }
                Console.WriteLine("Tu resultado es: {0}", resultado);
            }
            else 
            {
                if (potencia == 0)
                {
                    Console.WriteLine("Tu resultado es: {0}", resultado);
                }
                else 
                {
                    potencia *= -1;
                    for (i = 1; i <= potencia; i++)
                    {
                        resultado *= numbase;
                    }

                    resultadoneg = (1/resultado);
                    Console.WriteLine("Tu resultado es: {0}", resultadoneg);
                }
            }
        }
    }
}
