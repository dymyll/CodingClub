using Microsoft.EntityFrameworkCore;
using CodingClub.Models;

namespace CodingClub.Models
{
    public class OfficerContext: DbContext
    {
        public OfficerContext (DbContextOptions<OfficerContext> options)
            :base(options)
            {
            }
            public DbSet<Officer> Officer {get;set;}
    
    }
    
}