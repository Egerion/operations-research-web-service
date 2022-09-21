using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ORMonll.Entity;
using Quickwire.Attributes;

namespace ORMonll.Config
{
   [RegisterService(ServiceLifetime.Transient)]
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> ORM_USER { get; set; }
    }
}