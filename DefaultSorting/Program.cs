using Generator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DefaultSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                array.Add(rand.Next(-100, 100));
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            int[] arr = SelectionSort(array);

            ShowerArray.Show(arr);
        }
        private static int FindMinValue(List<int> array)
        {
            int smallest = array[0];
            int smallestIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] < smallest)
                {
                    smallestIndex = i;
                    smallest = array[i];
                }
            }
            return smallestIndex;
        }
        private static int[] SelectionSort(List<int> array)
        {
            List<int> newArray = new List<int>();
            int count = array.Count;
            for (int i = 0; i < count; i++)
            {
                int smallest = FindMinValue(array);
                newArray.Add(array[smallest]);
                array.Remove(array[smallest]);
            }
            return newArray.ToArray();
        }
    }
}
