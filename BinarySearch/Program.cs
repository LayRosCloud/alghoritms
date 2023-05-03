using Generator;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            GeneratorArray.Generate(array, -1000, 1000);
            SortedArray.Sort(array);
            ShowerArray.Show(array);

            int index = BinarySearch(array, array[4]);
            Console.WriteLine($"Индекс элемента {array[4]}: {index}");
            string[] phones = { "3213", "31231", "76564" };
            string[] person = { "Гриша", "Гоша", "Маша" };

            string number = BinarySearchOnText(phones, person, "Маша");
            Console.WriteLine(number);
            Console.WriteLine(BinarySearchOnPhone(phones, person, number));
        }

        private static int BinarySearch(int[] array, int searchedValue)
        {
            int low = 0;
            int high = array.Length;

            while(low <= high)
            {
                var middle = (low + high) / 2;
                int guess = array[middle];

                if(guess == searchedValue)
                {
                    return middle;
                }
                
                if(searchedValue < guess)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }

        private static string BinarySearchOnText(string[] phone, string[] lastNames, string findLastName )
        {
            int low = 0;
            int high = phone.Length;

            while(low <= high) 
            {
                int middle = (low + high) / 2;
                string guess = lastNames[middle];
                
                if(guess == findLastName)
                {
                    return phone[middle];
                }
                
                if(findLastName.CompareTo(guess) < 0)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }

            }
            return null;
        }
        private static string BinarySearchOnPhone(string[] phone, string[] lastNames, string findPhone)
        {
            int low = 0;
            int high = phone.Length;

            while (low <= high)
            {
                int middle = (low + high) / 2;
                string guess = phone[middle];

                if (guess == findPhone)
                {
                    return lastNames[middle];
                }

                if (findPhone.CompareTo(guess) < 0)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }

            }
            return null;
        }
    }
}
