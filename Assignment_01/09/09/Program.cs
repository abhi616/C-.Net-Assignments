using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;

            Console.Write(" Enter Count Of Query : ");
            q = Convert.ToInt32(Console.ReadLine());

            Find_CountOf_Divisors(q);

            Console.ReadKey();
        }

        static int Find_CountOf_Divisors(int Q)
        {
            int[] Query = new int[Q];
            int Div = 0, Cnt = 0;

            for (int i = 0; i < Q; i++)
            {
                Console.Write("\n Enter " + (i+1) + " Number : ");
                Query[i] = Convert.ToInt32(Console.ReadLine());

                if (Query[i] < 0)
                {
                    Query[i] = -(Query[i]);
                }
            }


            for (int i = 0; i <= Query[i]; i++)
            {
                for (int j = 0; j <= Query[i]; j++)
                {
                    if (j == 0||i==0)
                    {
                        continue;
                    }

                   if(i % j == 0)
                    {
                        Div++;
                    }

                    if (Div == 3&&i<=Query[i])
                    {
                        Console.WriteLine("\n "+Div +" is a Number Whose Have 3 Divisors And Also Less Than Or Equal To " + Query[i]);
                    }
                }
                Div = 0;
            }

                return Cnt;
        }
    }
}
