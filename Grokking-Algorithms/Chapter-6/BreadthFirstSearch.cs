using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_6
{
    public class BreadthFirstSearch
    {
        public Dictionary<string, string[]> _graph = new Dictionary<string, string[]>();
        
        public bool Search(string name)
        {
            var searchQueue = new Queue<string>(_graph[name]);
            var searched = new List<string>();
            while (searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if (!searched.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} is a mango seller");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(_graph[person]));
                        searched.Add(person);
                    }
                }
            }
            return false;
        }

        private static bool PersonIsSeller(string name)
        {
            return name.EndsWith("m");
        }
    }
}