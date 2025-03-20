using Microsoft.EntityFrameworkCore;

namespace Classtask1_180325.DATA
{
    public class AppDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
