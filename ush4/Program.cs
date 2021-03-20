using System;

namespace ush4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            String perf = null;
            int mbetje = 0;
            Boolean check = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    while (num > 0)
                    {
                        mbetje = num % 2;
                        num /= 2;
                        perf = mbetje.ToString() + perf;
                    }
                    Console.WriteLine("Number converted to binary: {0}", perf);
                    check = false;
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine(e.Message);
                }
            }
            while (num < 0 || check == true);
          }
    }
}
