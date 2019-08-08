using ClassLibrary1.Exceptions;
using ClassLibrary2;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Domain
{
    public class Catalog
    {
        public Catalog(int id, string title, List<CatalogItem> items, Product product = null)
        {
            if (id == 0)
                throw new NullOrEmptyException();

            if (string.IsNullOrEmpty(title))
                throw new NullOrEmptyException();            

            Id = id;
            Title = title;
            Items= items ?? new List<CatalogItem>();
            MainProduct = product;
        }
        public int Id { get; }

        public string Title { get; }
        public List<CatalogItem> Items { get; }
        public Product MainProduct { get; }
    }
}
