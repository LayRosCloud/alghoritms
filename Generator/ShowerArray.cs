using System;

namespace Generator
{
    public class ShowerArray
    {
        public static void Show(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
