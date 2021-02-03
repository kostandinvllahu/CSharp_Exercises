using System;

namespace Ush3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("Vendos numerat: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];
            
            for(int i = 0; i<num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            //Duhet se e printon keq
            for(int i = 0; i<num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            for(int i = 0; i<num.Length; i++)
            {
            if (num[i] % 2 != 0)
            {
                Console.WriteLine("\nThere are odd numbers");
            }
            else
            {
                Console.WriteLine("\nThere are no odd numbers");
            }

            }
        }
    }
}
