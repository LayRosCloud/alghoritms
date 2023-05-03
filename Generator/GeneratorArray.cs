using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class GeneratorArray
    {
        public static void Generate(int[] array, int min = 0, int max = 10) 
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }
        }
    }
}
