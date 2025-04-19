using System.Linq;
using BookStore.Models; // Category modelin bu namespace'teyse ekle
using BookStore.Data;   // ApplicationDbContext bu namespace'teyse ekle

namespace BookStore
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated(); 

            if (context.Categories.Any())
            {
                return; // Zaten veri varsa ekleme
            }
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { Name = "John Doe", Email = "johndoe@example.com" },
                    new Customer { Name = "Jane Smith", Email = "janesmith@example.com" }
                );
                context.SaveChanges();
            }

            var categories = new Category[]
            {
                new Category { Name = "Roman" },
                new Category { Name = "Bilim" },
                new Category { Name = "Korku" },
                new Category { Name = "Felsefe" }
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();
        }
    }
}
