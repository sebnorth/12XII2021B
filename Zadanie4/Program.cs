using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) {

                // (a, b) = (b, a);
                a = a + b;
                b = a - b; // a + b - b = a
                a = a - b; // a + b - a = b
            }

            
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
