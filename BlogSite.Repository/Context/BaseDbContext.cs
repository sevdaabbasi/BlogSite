using BlogSite.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Repository.Context;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
        throw new NotImplementedException();
    }

    public DbSet<Post> Posts { get; set; }
}