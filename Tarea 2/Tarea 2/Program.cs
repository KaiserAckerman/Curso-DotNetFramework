using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa de computadora que haga el calculo del area y perimetro de un rectangulo.

            //Variables
            double altura, ancho, area, perimetro;
            //Pedimos la altura y convertimos a tipo double
            Console.WriteLine("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            //pedimos el ancho y convertimos a tipo double
            Console.WriteLine("Dame la base:");
            ancho = Convert.ToDouble(Console.ReadLine());
            //Calcular el area
            area = altura * ancho;
            //Calcular perimetro
            perimetro = 2 * (altura + ancho);
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);

            //Hacer un programa que calcule el perimetro de cualquier poligono regular

            int lados;
            double perimetro2, tamañolado;

            Console.WriteLine("Dame el numero de lados: ");
            lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el tamaño de los lados: ");
            tamañolado = Convert.ToDouble(Console.ReadLine());
            
            perimetro2 = lados * tamañolado;
            Console.WriteLine("El perimetro del poligono regular es: {0}", perimetro2);

            //Hacer un programa que transforme de grados Centigrados a grados Fahrenheit

            double gradosC, GradosF;
            Console.WriteLine("Dime la cantidad de grados");
            gradosC = Convert.ToDouble(Console.ReadLine());
            GradosF = (gradosC * 1.8) + 32;
            Console.WriteLine("La cantidad de grados Fahrenheit es: {0}", GradosF);
        }
    }
}
