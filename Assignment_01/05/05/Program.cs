using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write("\n Enter Number : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n-----------------------------------------------------------------\n\n Perfect Squares : ");

            Console.Write("\n\n Total Perfect Square Numbers Less Than "+ N + " = " + Find_Perfect_Square_Numbers(N));

            Console.WriteLine("\n\n-----------------------------------------------------------------");

            Console.ReadKey();
        }

        static int Find_Perfect_Square_Numbers(int n)
        {
            int Cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i * i < n)
                {
                    Console.Write("  "+i*i);
                    Cnt++;
                }
            }

                return Cnt;
        }
    }
}
