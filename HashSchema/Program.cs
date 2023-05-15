using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HashSchema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Hashtable()
            {
                {"rel", "href"},
                {"domain", "http://localhost:8000" },
                {"users", "/users"},
                {"posts", "/posts"},
                {"gaben", "/gabens"},
            };
            Stopwatch stopwatch= new Stopwatch();
            stopwatch.Start();

            string result = dictionary["gaben"].ToString();

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }
    }
}
