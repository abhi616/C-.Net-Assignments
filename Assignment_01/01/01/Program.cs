using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 0;

            Console.Write("Enter a Number For Print The Pattern : ");
            N = Convert.ToInt32(Console.ReadLine());

            for (; N == 13; )
            {
                Console.Write("Enter a Number For Print The Pattern : ");
                N = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\n---------------------------------------------------------\n\n");

            Display_Pattern(N);

            Console.Write("\n---------------------------------------------------------");

            Console.ReadKey();
        }

        static void Display_Pattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > 0; j--)
                {
                    for (int k = n; k > i; k--)
                    {
                        Console.Write(" "+j);

                    }
                }

                Console.WriteLine();
            }
        }

    }
}
