using Microsoft.EntityFrameworkCore;
using SwiezeBackend.Models;

namespace SwiezeBackend.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}