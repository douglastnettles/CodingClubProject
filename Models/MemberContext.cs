using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext (DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member {get;set;}
    }
}