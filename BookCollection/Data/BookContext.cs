using BookCollection.Models; // 确保引用了 Book 模型所在的命名空间
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data {
    public class BookContext : DbContext {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {

        }

        public DbSet<Book> Book {get; set;}
    }
}