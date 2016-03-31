using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task5.Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        [TestCase(13,156,7,89,14,287,11,46,Result = 7)]
        public int BubbleSort_Test(params int[] ints)
        {
            ints.BubbleSort(((x, y) => x.CompareTo(y)));
            return ints[0];
        }
    }
}
