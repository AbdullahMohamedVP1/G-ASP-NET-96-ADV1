using System.Collections.Generic;

namespace Advanced_Assignment1
{
    //Q2: Write a generic class Container<T> with Add and Get methods.
    class Container<T>{
        private List<T> items = new List<T>();
        public void Add(T item) { items.Add(item);}
        public T Get(int index) { return items[index];}
    }
}