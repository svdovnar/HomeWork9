using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class MyCollection<T>
    {
        List<T> models = new List<T>();
        public T this[int index]
        {
            get { return (T)models[index]; }
            set { models[index] = value; }
        }
        public void Add(T value)
        {
            models.Add(value);
        }
        public int Count
        {
            get { return models.Count; }
        }

    }
}
