namespace ManyToMany.Data
{
    public class Book
    {
        public string Title { get; set; }
        public string? Publisher { get; set; }
        public int Id { get; private set; }
        public DateTime? ReleaseDate { get; set; }
        public Book(string title, string? publisher = default, int id = default)
        {
            (Title, Publisher, Id) = (title, publisher, id);
        }
        public virtual ICollection<Person> Authors { get; set; }
    }
    public class PageInformation
    {
        public int Id { get; set; }
        public int NumberOfPage { get; set; }
        public PageLayout PageLayout { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
    public enum PageLayout
    {
        Portrait = 1,
        Landscap = 2,
    }
}