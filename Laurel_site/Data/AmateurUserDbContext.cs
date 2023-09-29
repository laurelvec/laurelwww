

namespace Laurel_site.Data;


public class AmateurUserDbContext : IdentityDbContext
{
    public DbSet<AmateurUser> AmateurUser { get; set; }
    public AmateurUserDbContext(DbContextOptions<AmateurUserDbContext> options)
        : base(options)
    {
    }
}
