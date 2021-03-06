using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Trash_Collector.Models;

namespace Trash_Collector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole

                {

                    Name = "Admin",
                    NormalizedName = "ADMIN",

                },
                new IdentityRole
                {
                    
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    
                },
                new IdentityRole
                {
                    
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    
                }
                ) ;
            
            
        }
    }
}
