using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.GenericList
{
    /// <summary>
    /// Holds a list of elements
    /// </summary>
    /// <typeparam name="T">The type of the elements</typeparam>
    class GenericList<T> : IEnumerable<T> where T:IComparable
    {
        private T[] elements;
        public int Capacity { get; private set; }
        private int currentIndex;

        /// <summary>
        /// Returnes the count of the elements
        /// </summary>
        public int Count
        {
            get { return this.elements.Length; }
        }

        public GenericList(int capacity)
        {
            if (capacity > 0)
            {
                this.Capacity = capacity;
                this.elements = new T[capacity];
                this.currentIndex = 0;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The capacity should be a positive number");
            }
        }

        /// <summary>
        /// Add an element to the list
        /// </summary>
        /// <param name="element">The element to add</param>
        public void Add(T element)
        {
            if(currentIndex == this.Capacity)
            {
                this.ExpandList();
            }

            this.elements[currentIndex] = element;
            this.currentIndex++;
        }

        /// <summary>
        /// Returns the element at the specified index
        /// </summary>
        /// <param name="index">The index to search</param>
        /// <returns>The element at the given index</returns>
        public T this[int index]
        {
            get
            {
                this.CheckIndex(index);
                return this.elements[index];
            }

            set
            {
                this.CheckIndex(index);
                this.elements[index] = value;
            }
        }

        /// <summary>
        /// Removes an element at a given index
        /// </summary>
        /// <param name="index">The index to remove at</param>
        public void RemoveAt(int index)
        {
            this.CheckIndex(index);
            for(int i = index; i < this.currentIndex - 1; i ++)
            {
                this[i] = this[i + 1];
            }

            this.Capacity--;
            this.currentIndex--;
            Array.Resize(ref this.elements, this.Capacity);
        }

        /// <summary>
        /// Inserts an element at a given index
        /// </summary>
        /// <param name="index">The index to insert at</param>
        /// <param name="element">The element to insert</param>
        public void InsertAt(int index, T element)
        {
            if(currentIndex == this.Capacity )
            {
                this.ExpandList();
            }
            this.CheckIndex(index);

            for (int i = this.currentIndex - 1; i > index; i --) 
            {
                this[i] = this[i - 1];
            }

            this[index] = element;
            this.currentIndex++;
        }

        /// <summary>
        /// Clears the whole list
        /// </summary>
        public void Clear()
        {
            Array.Resize(ref this.elements, 0);
            this.currentIndex = -1;
            this.Capacity = 0;
        }

        /// <summary>
        /// Searches for an element and returns it index
        /// </summary>
        /// <param name="value">The element to search</param>
        /// <returns>The index of the element</returns>
        public int IndexOf(T value)
        {
            for(int i = 0; i < this.currentIndex; i ++)
            {
                if(this[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.currentIndex; i ++)
            {
                yield return this.elements[i];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            if (this.currentIndex >= 0)
            {
                for (int i = 0; i < currentIndex; i++)
                {
                    sb.Append(string.Format("{0}, ", this[i]));
                }
            }

            sb.Append("]");
            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Checks if the index is valid for the list
        /// </summary>
        /// <param name="index">The index to check</param>
        private void CheckIndex(int index)
        {
            if(index < 0 || index >= this.Capacity)
            {
                throw new ArgumentOutOfRangeException("Index is not in the list's range");
            }
        }

        /// <summary>
        /// Expands the capacity of the list by doubling it
        /// </summary>
        private void ExpandList()
        {
            Array.Resize(ref this.elements, this.Capacity * 2 );
            this.Capacity *= 2;
        }

        /// <summary>
        /// Gets the minimal element in the list
        /// </summary>
        /// <returns>The minimal element</returns>
        public T Min()
        {
            return this.elements.Min();
        }

        /// <summary>
        /// Gets the maximal element in the list
        /// </summary>
        /// <returns>The maximal element</returns>
        public T Max()
        {
            return this.elements.Max();
        }
    }
}
