using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    public class GenericList<T> where T : IComparable
    {
        private T[] elements;
        private int count = 0;
        private int capacity;

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }
        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.Capacity = capacity;
        }
        public int Count
        {
            get { return this.count; }
        }
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                //throw new IndexOutOfRangeException(String.Format(
                //"The list capacity of {0} was exceeded.", elements.Length));
                DoubleSize();
            }
            this.elements[count] = element;
            count++;
        }
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
            set { this.elements[index] = value; }
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T removedElement = this.elements[index];
            for (int i = index; i < count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            count--;
            return removedElement;
        }
        public void Insert(T element, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException(String.Format(
                   "Invalid index: {0}.", index));
            }
            if (count == this.elements.Length)
            {
                DoubleSize();
            }
            for (int i = count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            count++;
        }
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                this.elements[i] = default(T);
            }
            count = 0;
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(element) == 0)
                {
                    return i;
                } 
            }
            return -1;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
                result.Append(" ");
            }
            return result.ToString().Trim();
        }
        public void DoubleSize()
        {
            int newSize = this.elements.Length * 2;
            T[] copyArray = new T[newSize];
            for (int i = 0; i < count; i++)
            {
                copyArray[i] = this.elements[i];
            }
            this.elements = copyArray;
            this.Capacity *= 2;
        }
        public T Min()
        {
            T min = this.elements[0];
            for (int i = 1; i < count; i++)
            {
                if (this.elements[i].CompareTo(min)<=0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.elements[0];
            for (int i = 1; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) >=0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }
}
