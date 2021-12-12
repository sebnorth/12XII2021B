using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku n:");
            uint n = Convert.ToUInt32(Console.ReadLine());

            for (int w = 0; w < n; w++) // w - numer wiersza
            {
                // gwiazdki w jednym wierszu: 
                for (int i = 0; i < n; i++) // i - numer kolumny
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
