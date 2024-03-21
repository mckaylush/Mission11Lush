namespace Mission11Lush.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Book> Books { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
