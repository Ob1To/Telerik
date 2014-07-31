namespace TaskFrom5To7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] list;

        private const int DEFAULT_CAPACITY = 16;

        public int Count { get; set; }

        public int Capacity { get; set; }

        public GenericList(int capacity = DEFAULT_CAPACITY)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.list = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.list[index];
            }
        }
        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }
            this.list[this.Count] = element;

            this.Count++;
        }

        public void Clear()
        {
            this.list = new T[this.Capacity];
            this.Count = 0;
        }

        public int IndexOf(T element)
        {
            return Array.IndexOf(this.list, element);
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index >= this.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }

            Array.Copy(this.list, index, this.list, index + 1, this.Count - index);

            this.Count++;
            this.list[index] = element;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            Array.Copy(this.list, index + 1, this.list, index, this.Count - index - 1);

            this.Count--;
            this.list[this.Count] = default(T);
        }

        public T Max()
        {
            return this.MinMax(true);
        }

        public T Min()
        {
            return this.MinMax(false);
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return string.Empty;
            }

            var array = new StringBuilder();

            for (uint index = 0; index < this.Count; index++)
            {
                array.AppendLine(string.Format("{0} = {1}", index, this.list[index]));
            }

            return array.ToString();
        }

        private T MinMax(bool operation) // max = true, min = false
        {
            T[] noDefaultsList = new T[this.Count];

            Array.Copy(this.list, 0, noDefaultsList, 0, this.Count);

            if (operation)
            {
                return noDefaultsList.Max();
            }
            else
            {
                return noDefaultsList.Min();
            }
        }

        private void Resize()
        {
            this.Capacity *= 2;

            T[] newList = new T[this.Capacity];
            Array.Copy(this.list, 0, newList, 0, this.Count);

            this.list = newList;
        }
    }
}
