using System;

namespace Ush1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Values that are inputed in the program
             * limitNumber tells the program to reach ther limit of 500
             * the divider finds all the prime number
            */
            int limitNumber = 500; 
            int divider = 2;
            int result = 0;


            for (int i = 2; i <= limitNumber; i++)
            {
                int x = 1;
                while (divider < i)
                {
                    if (i % divider == 0)
                    {
                        x = 0;
                        break;
                    }
                    divider++;
                }
                if (x == 1)
                {
                    result += i;
                }
            }

            Console.WriteLine("The sum of prime numbers is: " + result);
        }
    }
}
