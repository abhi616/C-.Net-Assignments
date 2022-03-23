using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = 0, K = 0;

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

            Console.Write("\n Enter Sum : ");
            K = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("\n------------------------------------------------------------------------");

            Find_Pair(arr,K);

            Console.WriteLine("\n\n------------------------------------------------------------------------");

            Console.ReadKey();
        }
          
 
        static void Find_Pair(int[] A,int k)
        {
               int Cnt = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine("\n "+i+"th Element = "+A[i]);
                }

                Console.WriteLine("\n\n Pairs Whose Sum = "+k+ " : \n\t");

                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if (i==j)
                        {
                            continue;
                        }
                        else
                        {
                            if (A[i] + A[j] == k)
                            {
                                Console.Write(" (" + A[i] + ","+A[j] + ")");
                                Cnt++;
                            }
                        }
                    }
                       
                }

                if (Cnt == 0)
                {
                    Console.WriteLine(" No Such Pair Found Whose Co-Ordinates Sum is equal to " + k);
                }

            return;
        }
     
        }
 }



          