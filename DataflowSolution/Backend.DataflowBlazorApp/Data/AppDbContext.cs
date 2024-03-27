using Microsoft.EntityFrameworkCore;
using Shared.DataflowBlazorApp.Models;

namespace Backend.DataflowBlazorApp.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> product { get; set; }
    }
}
