namespace Mission11Lush.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
