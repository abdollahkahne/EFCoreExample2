namespace ManyToMany.Data
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; private set; }
        public Person(string firstName, string lastName, int id = default)
        {
            (FirstName, LastName, Id) = (firstName, lastName, id);
        }
        public virtual ICollection<Book> WrittenBooks { get; set; }
    }
}

