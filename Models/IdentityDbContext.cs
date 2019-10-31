using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MusicStore.Models
{
    public class IdentityDbContext:IdentityDbContext<ApplicationUser,ApplicationUserRole,int>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options):base(options)
        {

        }
    }
}
