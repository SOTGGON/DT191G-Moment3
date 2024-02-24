using BookCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data {
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {

        }

        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors { get; set; } 
        public DbSet<Borrow> Borrows { get; set; } 
    }
}