using DotNetCore8MvcWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore8MvcWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
