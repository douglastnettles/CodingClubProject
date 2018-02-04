using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext (DbContextOptions<AdminContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member {get;set;}

        public DbSet<Assignment2.Models.Admin> Admin { get; set; }
    }
}