using System;

namespace Ush5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Vendos nga 1-7 per te pare ditet e javes: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("E hene");
                    break;

                case 2:
                    Console.WriteLine("E marte");
                    break;

                case 3:
                    Console.WriteLine("E merkure");
                    break;

                case 4:
                    Console.WriteLine("E enjte");
                    break;

                case 5:
                    Console.WriteLine("E premte");
                    break;

                case 6:
                    Console.WriteLine("E shtune");
                    break;

                case 7:
                    Console.WriteLine("E diele");
                    break;
            }
            if (num >= 8)
            {
                Console.WriteLine("Vendos nga 1 deri ne 7");
            }
        }
    }
}
