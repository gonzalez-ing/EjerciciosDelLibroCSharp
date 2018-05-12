using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite el numero: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadLine();
        }
    }
}
