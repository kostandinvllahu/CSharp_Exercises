using System;

namespace Ush3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int temp = 0;
            Boolean check = false;
            Console.WriteLine("Input the amount of numbers that you want to input: ");
            do
            {
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input " + size + " numbers:");
                    int[] num = new int[size];

                    for (int i = 0; i < num.Length; i++)
                    {
                        num[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    //Duhet se e printon keq
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.Write(num[i] + " ");
                    }
                    for (int i = 0; i < num.Length; i++)
                    {
                        temp = num[i];
                    }

                    if (temp % 2 != 0)
                    {
                        Console.WriteLine("\nThere are odd numbers");
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("\nThere are no odd numbers");
                        check = false;
                    }
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine(e.Message);
                }
            }
            while (size < 0 || check == true);
          }
    }
}
