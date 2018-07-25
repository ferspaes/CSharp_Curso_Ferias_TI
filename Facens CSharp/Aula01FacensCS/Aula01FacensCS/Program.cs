using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01FacensCS
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            double delta, a1, a2;
            // Console.WriteLine(a);
            Console.WriteLine("Digite o valor de a:\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:\n");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de c:\n");
            c = -(Convert.ToInt32(Console.ReadLine()));

            delta = (b * b) - (4 * a * c);
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Raiz 1 = " 
                              + a1
                              + "\nRaiz 2 = "
                              + a2);
            Console.ReadKey();
        }
    }
}
