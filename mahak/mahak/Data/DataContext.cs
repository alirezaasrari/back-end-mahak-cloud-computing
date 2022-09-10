using mahak.Models;
using Microsoft.EntityFrameworkCore;

namespace mahak.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Register> Register { get; set; }

    }
}
