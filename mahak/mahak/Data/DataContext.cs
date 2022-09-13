using mahak.Models;
using Microsoft.EntityFrameworkCore;

namespace mahak.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Register> Register { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Roll> Roll { get; set; }

    }
}
