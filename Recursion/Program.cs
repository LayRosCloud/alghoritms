using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print(Factorial(10));
        }
        
        private static void print(object obj) => Console.WriteLine(obj);

        private static uint Fib(uint number)
        {
            if (number == 1 || number == 0) 
            {
                return number;
            }

            return Fib(number - 1) + Fib(number - 2);
        }

        private static uint Factorial(uint number)
        {
            if(number == 1 || number == 0)
            {
                return number;
            }

            return number * Factorial(number - 1);
        }
    }
}
