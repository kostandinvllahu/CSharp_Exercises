using System;
using System.Linq;

namespace ush2
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = null;
            String reverse = null;
            Console.WriteLine("Vendos fjalen");
            word = Console.ReadLine();
            reverse = string.Join(" ", word.Split(' ').Select(w => new String(w.Reverse().ToArray())));
            Console.WriteLine(reverse);
        }
    }
}
