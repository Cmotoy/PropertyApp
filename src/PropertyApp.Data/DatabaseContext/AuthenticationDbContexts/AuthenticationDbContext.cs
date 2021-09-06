using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyApp.Data.Entities;

namespace PropertyApp.Data.DatabaseContext.AuthenticationDbContexts
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options ) : base (options)
        {    
        }
    }
}