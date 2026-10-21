using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CP24
{
    public class Repository<T> where T : Entity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T? GetById(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }
    }
}
