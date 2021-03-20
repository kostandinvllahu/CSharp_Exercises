using System;

namespace ush8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;
            Boolean check = false;
            do
            {
                try
                {
                    Console.WriteLine("Input the value of a natural number");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("Only natural numbers");
                    }
                    else
                    {
                        for (int i = 0; i <= num; i++)
                        {
                            result += i;
                        }
                        Console.WriteLine(result);
                        check = false;
                    }
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine(e.Message);
                }
            }
            while (check == true || num <= 0);
        }
         
    }
}
