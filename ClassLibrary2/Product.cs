using System;

namespace ClassLibrary2
{
    public class Product
    {
        public Product(int id)
        {
            if (id == 0)
                throw new Exception();
            if(id < 0)
                throw new Exception();
            Id = id;
        }

        public Product(string title)
        {
            Title = title;
        }

        public Product(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; }
        public string Title { get; }
    }
}
