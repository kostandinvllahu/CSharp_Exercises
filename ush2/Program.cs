using System;
using System.Linq;

namespace ush2
{
    class Program
    {

        static void reverse(string rec)
        {

        }
        static void Main(string[] args)
        {
            string word = null;
            int count = 0;

            Console.WriteLine("Enter a sentence to be reversed");
            word = Console.ReadLine();
            char[] ch = word.ToCharArray();
            Console.WriteLine("Word after reverse: ");
            for(int i = ch.Length -1; i>=0; i--)
            {
                if (ch[i] != ' ')
                {
                    count++;
                }
                else if(ch[i] == ' ')
                {
                    for(int j=i+1; count>0; j++, count--)
                    {
                        Console.WriteLine(ch[j]);
                    }
                    Console.WriteLine(" ");
                }
            }
            for(int j=0; j<=count; j++)
            {
                Console.WriteLine(ch[j]);
            }
            Console.ReadLine();

        }
    }
}
