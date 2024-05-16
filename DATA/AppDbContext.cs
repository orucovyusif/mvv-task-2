using Mamba_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mamba_mvc.DATA
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Store> Stores { get; set; }
    }
}
