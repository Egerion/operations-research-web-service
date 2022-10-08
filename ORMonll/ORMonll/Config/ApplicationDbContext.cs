using Microsoft.EntityFrameworkCore;
using ORMonll.Entity;
using Quickwire.Attributes;

namespace ORMonll.Config
{
    [RegisterService]
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> ORM_USER { get; set; }
    }
}