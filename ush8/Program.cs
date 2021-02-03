using System;

namespace ush8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;

            Console.WriteLine("Vendos vleren e nje nr natyror");
            num = Convert.ToInt32(Console.ReadLine());
            if(num < 0)
            {
                Console.WriteLine("Vetem nr natyror!");
            }
            else
            {
                for(int i=0; i<=num; i++)
                {
                    result += i;
                }
                Console.WriteLine(result);
            }
        }
    }
}
