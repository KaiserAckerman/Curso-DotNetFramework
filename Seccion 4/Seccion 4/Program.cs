using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            //Asignacion compuesta

            int x = 2;

            Console.WriteLine(x);

            x += 5;// x = x+5;
            Console.WriteLine(x);
            x -= 5;// x = x-5;
            Console.WriteLine(x);
            x *= 5;// x = x*5;
            Console.WriteLine(x);
            x /= 5;//x=x/5;
            Console.WriteLine(x);

        }
    }
}
