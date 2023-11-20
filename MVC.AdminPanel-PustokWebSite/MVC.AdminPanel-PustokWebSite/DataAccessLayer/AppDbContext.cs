using Microsoft.EntityFrameworkCore;
using MVC.AdminPanel_PustokWebSite.Models;

namespace MVC.AdminPanel_PustokWebSite.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Service> Services { get; set; }
    }
}
