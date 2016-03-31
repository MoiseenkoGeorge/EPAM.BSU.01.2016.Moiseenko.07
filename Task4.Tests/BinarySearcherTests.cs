using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task4.Tests
{
    [TestFixture]
    public class BinarySearcherTests
    {
        [Test]
        [TestCase(11,13,145,67,14,89,116,34,11,Result = 0)]
        public int BinarySearch_Test(int value, params int[] ints)
        {
            Array.Sort(ints);
            return ints.BinarySearch(value);
        }
    }
}
