using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task3.Tests
{
    [TestFixture]
    public class CustomQueueTest
    {
        [Test]
        [TestCase(1,2,3,Result = 2)]
        [TestCase(3, 2, 1, Result = 2)]
        public int Dequeue_Test(params int[] ints)
        {
            CustomQueue<int> customQueue = new CustomQueue<int>();
            foreach (var element in ints)
                customQueue.Enqueue(element);
            customQueue.Dequeue();
            return customQueue.Count;
        }
        [Test]
        [TestCase(1, 2, 3, Result = 2)]
        [TestCase(3, 2, 1, Result = 2)]
        public int Peek_Test(params int[] ints)
        {
            CustomQueue<int> customQueue = new CustomQueue<int>();
            foreach (var element in ints)
                customQueue.Enqueue(element);
            customQueue.Dequeue();
            return customQueue.Peek();
        }
    }
}
