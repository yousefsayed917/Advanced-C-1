using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q5
{
    internal class FixedSizeList<T>
    {
        private T[] arr;
        private int capacity;
        private int items;
        
        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            items = 0;
            arr = new T[capacity];
        }
        public void Add(T item)
        {
            try
            {
                arr[items] = item;
                items++;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public T GetValue(int index) 
        { 
        if(index> capacity)
                throw new IndexOutOfRangeException();
        return arr[index];
        }
        public void Display()
        {
            for (int i = 0; i < items; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
