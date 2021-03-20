using System;

namespace Ush5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Boolean check = false;
            do
            {
                try
                {
            Console.WriteLine("Vendos nga 1-7 per te pare ditet e javes: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("E hene");
                    check = false;
                    break;

                case 2:
                    Console.WriteLine("E marte");
                            check = false;
                            break;

                case 3:
                    Console.WriteLine("E merkure");
                            check = false;
                            break;

                case 4:
                    Console.WriteLine("E enjte");
                            check = false;
                            break;

                case 5:
                    Console.WriteLine("E premte");
                            check = false;
                            break;

                case 6:
                    Console.WriteLine("E shtune");
                            check = false;
                            break;

                case 7:
                    Console.WriteLine("E diele");
                            check = false;
                            break;
            }
            if (num >= 8)
            {
                Console.WriteLine("Vendos nga 1 deri ne 7");
            }
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine(e.Message);
                }
            }
            while (num <= 0 || check == true || num >= 8);
        }
}
}
            
