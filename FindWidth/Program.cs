using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWidth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable graph = new Hashtable();
            string[] param = {"alice", "bob", "claire" };
            string[] param1 = { "anuj", "peggy" };
            string[] param2 = { "peggy" };
            string[] param3 = { "thom", "johny" };
            graph.Add("you", param);
            graph.Add("bob", param1);
            graph.Add("alice", param2);
            graph.Add("claire", param3);
            graph.Add("anuj", new string[0]);
            graph.Add("peggy", new string[0]);
            graph.Add("thom", new string[0]);
            graph.Add("johny", new string[0]);

            Queue<string> searchQueue = new Queue<string>();
            searchQueue.Enqueue("you");

            FindMangoShoper(graph, searchQueue);
        }

        private static bool FindMangoShoper(Hashtable graph, Queue<string> searchQueue)
        {
            List<string> searched = new List<string>();

            while (searchQueue.Count != 0)
            {
                string person = searchQueue.Dequeue();
                if (IsShopMango(person))
                {
                    Console.WriteLine($"{person} is shop mango");
                    return true;
                }

                searched.Add(person);

                string[] valueGraph = (string[])graph[person];

                foreach (var item in valueGraph)
                {
                    if(!searched.Contains(item))
                    Console.WriteLine($"{person}: {item}");
                        searchQueue.Enqueue(item);
                }
            }

            return false;
        }

        private static bool IsShopMango(string key)
        {
            return key == "thom";
        }
    }
}
