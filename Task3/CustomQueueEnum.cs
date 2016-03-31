using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task3
{
    public class CustomQueueEnum<T> : IEnumerator<T>
    {
        private readonly T[] _array;
        private int pointer = -1;
        public T Current
        {
            get
            {
                if (pointer != -1)
                    return _array[pointer];
                throw new InvalidOperationException();
            }
        }

        object IEnumerator.Current => Current;

        public CustomQueueEnum(T[] array)
        {
            _array = array;
        }
        public void Dispose() { }

        public bool MoveNext()
        {
            if (pointer < _array.Length - 1)
            {
                pointer++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            pointer = -1;
        }
    }
}