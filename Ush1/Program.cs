using System;

namespace Ush1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 500; //Vlera qe futet ne program
            int a = 2;
            int sum = 0;


            for (int i = 2; i <= num; i++)
            {
                int x = 1;
                while (a < i)
                {
                    if (i % a == 0)
                    {
                        x = 0;
                        break;
                    }
                    a++;
                }
                if (x == 1)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Shuma e numrave prim: " + sum);
        }
    }
}
