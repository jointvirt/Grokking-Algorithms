using System;
using Chapter_6;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests
{
    public class Chapter6Test
    {
        private readonly BreadthFirstSearch _breadthFirstSearch = new BreadthFirstSearch();
        
        [TestCase("you", ExpectedResult = true)]
        public bool BreadthFirstSearch_Search_ReturnsBoolean(string name)
        {
            _breadthFirstSearch._graph.Add("you", new[] { "alice", "bob", "claire" });
            _breadthFirstSearch._graph.Add("bob", new[] { "anuj", "peggy" });
            _breadthFirstSearch._graph.Add("alice", new[] { "peggy" });
            _breadthFirstSearch._graph.Add("claire", new[] { "thom", "jonny" });
            _breadthFirstSearch._graph.Add("anuj", Array.Empty<string>());
            _breadthFirstSearch._graph.Add("peggy", Array.Empty<string>());
            _breadthFirstSearch._graph.Add("thom", Array.Empty<string>());
            _breadthFirstSearch._graph.Add("jonny", Array.Empty<string>());
            
            return _breadthFirstSearch.Search(name);
        }
    }
}