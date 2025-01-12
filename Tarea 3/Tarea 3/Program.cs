using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.
            int numero;
            Console.WriteLine("Escribe un numero del 1 al 12: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero <= 12 && numero >= 1)
            {
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Escogiste el mes de enero");
                        break;

                    case 2:
                        Console.WriteLine("Escogiste el mes de febrero");
                        break;
                    case 3:
                        Console.WriteLine("Escogiste el mes de marzo");
                        break;
                    case 4:
                        Console.WriteLine("Escogiste el mes de abril");
                        break;
                    case 5:
                        Console.WriteLine("Escogiste el mes de mayo");
                        break;
                    case 6:
                        Console.WriteLine("Escogiste el mes de junio");
                        break;
                    case 7:
                        Console.WriteLine("Escogiste el mes de julio");
                        break;
                    case 8:
                        Console.WriteLine("Escogiste el mes de agosto");
                        break;
                    case 9:
                        Console.WriteLine("Escogiste el mes de septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Escogiste el mes de octubre");
                        break;
                    case 11:
                        Console.WriteLine("Escogiste el mes de noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Escogiste el mes de diciembre");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Escoge un numero correcto");
            }

            //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

            int numpar;
            Console.WriteLine("Escribe un numero");
            numpar = Convert.ToInt32(Console.ReadLine());

            if (numpar % 2 == 0)
            {
                Console.WriteLine("Tu numero es par");
            }
            else
            {
                Console.WriteLine("Tu numero es impar");
            }

            //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00
            int numHoras;
            double total;
            Console.WriteLine("Ingrese el numero de horas estacionado");
            numHoras = Convert.ToInt32(Console.ReadLine());
            switch(numHoras) {
                case 1:
                    total = 5.0;
                    Console.WriteLine("Tu total a pagar es de: ${0}", total);
                    break;
                case 2:
                    total = 15.00;
                    Console.WriteLine("Tu total a pagar es de: ${0}", total);
                    break;
                default:
                    if (numHoras >= 3)
                    {
                        total = 20.00 + (40 * (numHoras - 2));
                        Console.WriteLine("Tu total a pagar es de: ${0}", total);
                    }
                    else
                    {
                        Console.WriteLine("Coloca un numero de horas correcto");
                    }
                    break;
            }

        }






    }
}
