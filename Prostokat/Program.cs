using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj szerokość boku a:");
            uint a = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Podaj wysokość boku b:");
            uint b = Convert.ToUInt32(Console.ReadLine());

            for (int w = 0; w < b; w++) // w - numer wiersza
            {

                // pierwszy wiersz

                if (w==0)
                {
                    // gwiazdki w jednym wierszu: 
                    for (int i = 0; i < a; i++) // i - numer kolumny
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); 
                }

                // rysowanie znaków dla wierszy pośrednich
                if (w>0 && w<b-1)
                {
                    // 1 gwiazdka
                    Console.Write("*");

                    // ile spacji (a-2)
                    for (int i = 0; i < a-2; i++) // i - numer kolumny
                    {
                        Console.Write(" ");
                    }

                    // 1 gwiazdka
                    Console.Write("*");

                    // przejście do nowej linii
                    Console.WriteLine();
                }


                // ostatni wiersz 

                if (w==b-1)
                {
                    // gwiazdki w jednym wierszu: 
                    for (int i = 0; i < a; i++) // i - numer kolumny
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); 
                }


            }

            Console.ReadKey();
        }
    }
}
