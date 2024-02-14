using BookCollection.Models; // 确保引用了 Author 模型所在的命名空间
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data {
    public class AuthorContext : DbContext {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options) {

        }

        public DbSet<Author> Author {get; set;}
    }
}