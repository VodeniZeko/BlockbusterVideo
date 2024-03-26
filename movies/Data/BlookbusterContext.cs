using Microsoft.EntityFrameworkCore;

namespace movies.Data
{
    public class BlockbusterContext : DbContext
    {
        public BlockbusterContext(DbContextOptions<BlockbusterContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }
    }
}
