using System;
using System.Collections.Generic;
using System.Text;
using Chapter_3;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests
{
    class Chapter3Test
    {
        private readonly Rekursion _rekursion = new Rekursion();
        
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(4, ExpectedResult = 24)]
        [TestCase(5, ExpectedResult = 120)]
        public int? Rekursion_Factorial_ReturnsExceptedNumber(int n)
        {
            return _rekursion.Factorial(n);
        }
    }
}
