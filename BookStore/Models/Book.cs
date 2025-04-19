using Microsoft.Identity.Client;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public Decimal Price { get; set; }
        public int ViewCount { get; set; }

        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}
