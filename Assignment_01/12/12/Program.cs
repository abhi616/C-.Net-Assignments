using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Up:
            Console.Write("\n Enter Elements Count : ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("\n Please Enter Positive Number.\n");
                goto Up;
            }

            int[] arr = new int[N];

            Console.WriteLine("\n------------------------------------------------------------------------");

            Alternate_Order(arr);

            Console.WriteLine("\n\n------------------------------------------------------------------------");

            Console.ReadKey();
        }
          
     static void Alternate_Order(int[] A)
        {

                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("\n Enter Element : ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\n------------------------------------------------------------------------");

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine("\n "+i+"th Element = "+A[i]);
                }

                Console.WriteLine("\n\n Elements In Alternate Order : \n\t");

                for (int j = 0; j < A.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(" " + A[j]);
                    }
                }


            return;
        }
    }
}
