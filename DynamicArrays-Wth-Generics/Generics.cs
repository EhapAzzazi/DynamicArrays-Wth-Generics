using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays_Wth_Generics
{
    class Generics<T> /* where T: class //, new() */
    {

        private T[] Items;
        public void Add(T _item)
        {
            if (Items == null)
            {
                Items = new T[] { _item };
            }
            else
            {
                var length = Items.Length + 1;
                T[] dest = new T[length];
                for (int i = 0; i < Items.Length; i++)
                {
                    dest[i] = Items[i];
                }
                dest[Items.Length] = _item;
                Items = dest;
                //dest = null;
            }
        }
        public void RemoveAt(int position)
        {
            if (position < 0 || position > Items.Length - 1)
            {
                Console.WriteLine("Not existed!");
                return;
            }

            var index = 0;
            var dest = new T[Items.Length - 1];
            for (int i = 0; i < Items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = Items[i];
            }
            Console.WriteLine($"Element {Items[position]} is deleted successfully.");
            Items = dest;
        }
        public void Print()
        {
            foreach (var c in Items)
            {
                Console.Write($"     {c}");
            }
            Console.WriteLine();
        }
        public bool IsEmpty() => Items == null;
        public int Count() => Items.Length != 0 ? Items.Length : 0;
    }
}
