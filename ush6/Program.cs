using System;

namespace ush6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 1;
            int factorial = 1;
            Boolean check = false;
            do
            {
                try
                {
                    Console.WriteLine("Input a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    for (i = 1; i <= num; i++)
                    {
                        factorial = i * factorial;
                    }
                    Console.WriteLine("Factrial of " + num + " is " + factorial);
                    check = false;
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine(e.Message);
                }
            } while (check == true || num <= 0);
        }
    }
}

