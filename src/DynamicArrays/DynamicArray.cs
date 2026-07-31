using System;
using System.Collections.Generic;
using System.Collections;


namespace DynamicArrays
{
    public class DynamicArray <T>: IEnumerable<T>
    {
        private T[] array;
        private int length; // Number of elements in the array that user thinks are in the array
        private int capacity; // Actual size of the array

        public DynamicArray()
        {
            capacity = 16;
            array = new T[capacity];
            length = 0;
        }

        public DynamicArray(int capacity)
        {
            this.array = new T[capacity];
            this.capacity = capacity;
            length = capacity;
        }

        public int Size()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public void Set (int index, T value)
        {
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            array[index] = value;
        }

        public void Clear()
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = default!;
            }
        }

        public void Add (T value)
        {
            if (length == capacity)
            {
                int newCapacity = capacity * 2;                
                T [] newArray = new T [newCapacity];
                for(int i = 0; i < capacity; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }

            array[length] = value;
            length++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];                
            }

            array[length - 1] = default!;
            length--;
        }

        public int IndexOf (T value)
        {
            int index = - 1;
            for (int i = 0; i < length; i++)
            {
                if(EqualityComparer<T>.Default.Equals(array[i], value))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public bool Remove (T value)
        {
            int index = IndexOf(value);

            if(index == -1)
            {
                return false;
            }

            RemoveAt(index);
            return true;
        }

        public bool Contains (T value)
        {
            return IndexOf(value) != -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            if(length == 0)
            {
                return "[]";
            }
            var result = "[";
            for (int i = 0; i < length; i++)
            {
                result += array[i]?.ToString() ?? "null";
                if (i < length - 1)
                {
                    result += ", ";
                }
            }
            result += "]";
            return result;
        }
    }
}