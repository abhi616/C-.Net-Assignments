using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 0, N2 = 0 , N;

            Console.Write(" Enter 1st Number : ");
            N1 = Convert.ToInt32(Console.ReadLine());           

            Console.Write("\n Enter 2nd Number : ");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Term Which You Want To Find : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n------------------------------------------------------------------------");

            Console.Write("\n\t"+N+"th Term Of The Series is = "+Find_Arithmetic_Series_Term(N1, N2,N));

            Console.WriteLine("\n\n------------------------------------------------------------------------");

            Console.ReadKey();
        }

        static int Find_Arithmetic_Series_Term(int n1, int n2,int n)
        {
            int Term = 0, Diff = 0;

            Diff = n2-n1;

            Term = n1 + (n - 1) * Diff;

            return Term;
        }
    }
}
