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
            int Num = 0;

            Up:
            Console.WriteLine(" Enter Number : ");
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num <= 0)
            {
                Console.WriteLine("Plaese Enter Positive Number.\n");     
                goto Up;
            }
            else
            {
                int Temp = Num;

                for (int i = 1; i <= Num; i++)
                {
                    for (int j = 1; j <= Temp*2; j++)
                    {
                        Console.Write(Temp);
                        if (j % 2 == 0)
                        {
                            Temp--;
                            Console.WriteLine();
                        }
                        
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
