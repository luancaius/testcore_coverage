
using System;

namespace ClassLibrary1.Domain
{
    public class Catalog
    {
        public Catalog(int id)
        {
            if (id == 0)
                throw new Exception();
            if (id < 0)
                throw new Exception();
            Id = id;
        }

        public Catalog(string title)
        {
            Title = title;
        }

        public Catalog(int id, string title, string description = null)
        {
            Id = id;
            Title = title;
            Description = description;
        }
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }
    }
}
