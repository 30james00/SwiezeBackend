using Microsoft.EntityFrameworkCore;
using SwiezeBackend.Models;

namespace SwiezeBackend.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}