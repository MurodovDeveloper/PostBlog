using Microsoft.EntityFrameworkCore;
using PostBlog.Models;

namespace PostBlog.DataAcces;
public class PostDbContext : DbContext
{
    public PostDbContext(DbContextOptions options) :base(options){}
    public DbSet<Post> Posts { get; set; }
}
