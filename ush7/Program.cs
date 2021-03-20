using System;

namespace ush7
{
    class Program
    {

        public static void Unique(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Boolean unique = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        unique = true;
                        break;
                    }
                }
                if (!unique)
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }
        static void Main(string[] args)
        {
           int [] arr = { 1, 5, 5, 5, 10, 4, 4, 3, 2 };
            Console.WriteLine("Vlerat: ");
            Array.Sort(arr);
            Unique(arr);
        }
    }
}
