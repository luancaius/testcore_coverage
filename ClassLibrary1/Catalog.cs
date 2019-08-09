
namespace ClassLibrary1.Domain
{
    public class Catalog
    {
        public Catalog(int id)
        {
            Id = id;
        }

        public Catalog(string title)
        {
            Title = title;
        }

        public Catalog(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; }
        public string Title { get; }
    }
}
