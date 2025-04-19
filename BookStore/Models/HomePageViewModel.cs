namespace BookStore.Models
{
    public class HomePageViewModel
    {

        public List<Book> MostViewedBooks { get; set; } = new List<Book>();

        public List<Book> NewBooks { get; set; } = new List<Book>();
    }
}
