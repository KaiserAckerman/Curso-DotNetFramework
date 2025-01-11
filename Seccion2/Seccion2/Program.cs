using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Precalentar el horno");
            Console.WriteLine("2. Mezclar harina y mantequilla");
            Console.WriteLine("3. Agregar azucar y 1 huevo");
            Console.WriteLine("4. Amasar la mezcla");
            Console.WriteLine("5. Darles forma y colocar en charola");
            Console.WriteLine("6. Hornear durante 10 minutos");

            int numeroLibros, librosninos, librosMatematicas;
            double promedioFinal = 9.8;

            numeroLibros = 500;

            char salon;
            salon = 'A';
            string saludo = "Hola";
            bool x = true;
            decimal promedioExamenes = 8.5m;
            float promedio = 8.5F;

            Console.WriteLine(5 + 5 + 8 + 2);

            int num1 = 8;
            double num2 = 4.5;
            double resultado;
            resultado = num1 + num2;
            Console.WriteLine(resultado);
            resultado = num1 + 22;
            Console.WriteLine(resultado);

            string saludo1 = "Hola";
            string nombre = "Hugo";
            Console.WriteLine(saludo + " " + nombre);
            Console.WriteLine(50 - 8);
            Console.WriteLine(2 * 2);

            string nombre2;
            Console.Write("Como te llamas?: ");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Hola {0}, un placer", nombre2);

            
            int num3 = 5, num4, resultado2;
            Console.WriteLine("Dame un numero para sumarlo : ");
          
            num4 = Int32.Parse(Console.ReadLine());
            resultado2 = num3 + num4;
            Console.WriteLine("El resultado de la suma es: {0}", resultado2);

           
        }
    }
}
