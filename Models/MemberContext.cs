using Microsoft.EntityFrameworkCore;
using CodingClub.Models;

namespace CodingClub.Models
{
    public class MemberContext: DbContext
    {
        public MemberContext (DbContextOptions<MemberContext> options)
            :base(options)
            {
            }
            public DbSet<Member> Members {get;set;}
            
    }
    
}