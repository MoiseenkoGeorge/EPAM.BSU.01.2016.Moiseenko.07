using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        private T[] array;
        public int Count { get; private set; } = 0;
        public int Capacity { get; private set; } = 10;
        
        public CustomQueue()
        {
            array = new T[Capacity];
        }

        public void Enqueue(T element)
        {
            if(Count == Capacity)
                Realloc();
            array[Count++] = element;
        }

        public T Dequeue()
        {
            T returnValue = array[0];
            T[] temp = new T[Capacity];
            for (int i = 1; i < Count; i++)
                temp[i] = array[i];
            return returnValue;
        }

        public T Peek()
        {
            if (Count != 0)
                return array[0];
            throw new InvalidOperationException("Queue is empty");
        }

        private void Realloc()
        {
            Capacity *= 2;
            T[] temp = new T[Capacity];
            for (int i = 0; i < Count; i++)
                temp[i] = array[i];
            array = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomQueueEnum<T>(array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
