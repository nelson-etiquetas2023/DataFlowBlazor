using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.DataflowBlazorApp.Models;

namespace Backend.DataflowBlazorApp.Data

{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<Product> Products { get; set; }
    } 
}
