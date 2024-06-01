using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BugTracker.Models.Ticket>? Ticket { get; set; }
        
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    
    }
}