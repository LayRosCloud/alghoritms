using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DivideAndConquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 2, 3 };
            Stopwatch watch = new Stopwatch();
            
            watch.Start();
            array = QSort(array);
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
            foreach (var item in QSort(array))
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        private static int Sum(int[] array, int length)
        {
            if(length < 0)
            {
                return 0;
            }

            return array[length] + Sum(array, length - 1);
        }
        
        private static int[] QSort(int[] array)
        {
            if(array.Length < 2)
            {
                return array;
            }
            int pivot = array[0];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            
            foreach (var item in array)
            {
                if(item < pivot)
                {
                    less.Add(item);
                }
                else if(item > pivot)
                {
                    greater.Add(item);
                }
            }
            
            List<int> result = new List<int>();

            result.AddRange(QSort(less.ToArray()));
            result.Add(pivot);
            result.AddRange(QSort(greater.ToArray()));
            
            return result.ToArray();
        }
    }
}
