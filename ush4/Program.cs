using System;

namespace ush4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String perf = null;
            int mbetje = 0;
            Console.WriteLine("Vendos numerin: ");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                mbetje = num % 2;
                num /= 2;
                perf = mbetje.ToString() + perf;
            }
            Console.WriteLine("Versioni Binarik: {0}", perf);
        }
    }
}
