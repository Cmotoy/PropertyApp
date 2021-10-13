using Microsoft.EntityFrameworkCore;
using PropertyApp.Data.Entities;

namespace PropertyApp.Data.DatabaseContext.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    
        public DbSet<Property> Properties {get; set;}
        public DbSet<Contact> Contacts {get; set;}
    }
}