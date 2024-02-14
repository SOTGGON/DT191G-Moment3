using BookCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data {
    public class BookContext : DbContext {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {

        }

        public DbSet<Book> Book {get; set;}
    }
}