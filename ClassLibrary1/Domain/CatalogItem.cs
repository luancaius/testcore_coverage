namespace ClassLibrary1.Domain
{
    public class CatalogItem
    {
        public CatalogItem(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; }
        public string Title { get; }
    }
}
