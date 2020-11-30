using System;
using System.Collections.Generic;

namespace Chapter_5
{
    public class HashTables
    {
        private static readonly Dictionary<string, bool> _voted = new Dictionary<string, bool>();
        
        public string Check(string name)
        {
            if (_voted.ContainsKey(name))
            {
                return "kick them out!";
            }
            else
            {
                _voted.Add(name, true);
                return "let them vote!";
            }
        }
    }
}