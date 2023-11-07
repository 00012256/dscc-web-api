using dscc_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dscc_web_api.DbContexts
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
