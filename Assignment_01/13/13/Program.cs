using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = 0;

            Up:
            Console.Write("\n Enter Elements Count : ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("\n Please Enter Positive Number.\n");
                goto Up;
            }

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n Enter "+ (i+1)+" Element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }  

            Console.WriteLine("\n------------------------------------------------------------------------");

            Remove_Duplicate(arr);

            Console.WriteLine("\n\n------------------------------------------------------------------------");

            Console.ReadKey();
        }

        static void Remove_Duplicate(int[] A)
        {
            int Cnt = 0;

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("\n " + i + "th Element = " + A[i]);
            }

            Console.WriteLine("\n\n After Removing Duplicate Element : \n\t");

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (A[i]==A[j])
                        {
                            A[i] = A[j];
                        }
                    }
                }

            }

            return;
        }
       
        
    }
}
