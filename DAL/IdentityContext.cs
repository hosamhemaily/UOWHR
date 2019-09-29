using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DAL.Models
{
    public partial class IdentityContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>, Guid>
    {
        public IdentityContext()
        {

        }

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {

        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);           
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");            
        }
    }
}
