using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grados;
            double radio;
            double lados;
            double Area;
            double altura;
            double baseT;
            //Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.
            Console.WriteLine("Escoga la la operacion");
            Console.WriteLine("1: Calcular el Area de un circulo");
            Console.WriteLine("2: Calcular el Area de un cuadrado");
            Console.WriteLine("3: Calcular el Area de un triangulo");
            Console.WriteLine("4: Calcular de grados a radianes");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduce el radio del circulo");
                    radio = Convert.ToDouble(Console.ReadLine());  
                    Area = calcularAreaCirculo(radio);
                    Console.WriteLine("El area del circulo es {0}", Area);
                    break;
                case 2:
                    Console.WriteLine("Introduce el tamaño de los lados");
                    lados=Convert.ToDouble(Console.ReadLine());
                    Area=calcularAreaCuadrado(lados);
                    Console.WriteLine("El area del cuadrado es {0}", Area);
                    break;
                case 3:
                    Console.WriteLine("Introduce la base");
                    baseT = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce la altura");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Area=calcularAreaTriangulo(baseT, altura);
                    Console.WriteLine("El area del Triangulo es {0}", Area);
                    break;
                case 4:
                
                    Console.WriteLine("Introduce la cantidad de grados a convertir");
                    grados = Convert.ToDouble(Console.ReadLine());
                    double r;
                    r = cambiarRadianes(grados);
                    Console.WriteLine("La cantidad de radianes es: {0}", r);
                    break;

                default:
                    Console.WriteLine("Escoge una opcion valida");
                    break;
            }

        }

        //Crear un método para transformar de grados a radianes

        static double cambiarRadianes(double grados)
        {
            double resultado = 0;
            resultado = (grados * Math.PI) / 180;
            return resultado;
        }

        static double calcularAreaCirculo(double radio)
        {
            double Area=(radio * radio) * Math.PI;
            return Area;
            
        }
        
        static double calcularAreaCuadrado(double lados)
        {
            double Area=(lados * lados);
            return Area;
        }

        static double calcularAreaTriangulo(double baseT, double altura)
        {
            double resultado = (baseT * altura) / 2;
            return resultado;
        }
    }
}
