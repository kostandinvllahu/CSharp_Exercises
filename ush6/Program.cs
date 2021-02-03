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

            Console.WriteLine("Vendos nje numer: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i<=num; i++)
            {
                factorial = i * factorial;
            }
            Console.WriteLine("Faktoriali i " + num + " eshte " + factorial);
        }
    }
}
