using Microsoft.EntityFrameworkCore;
using SimpleWine.Models;

namespace SimpleWine.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { 
        }

        public DbSet<VinhoModel> Vinhos { get; set; }


    }
}
