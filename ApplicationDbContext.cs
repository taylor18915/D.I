using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using D.I_Tech_Nigh_School.Data;

namespace D.I_Tech_Nigh_School.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<D.I_Tech_Nigh_School.Data.Drinks> Drinks { get; set; }
        public DbSet<D.I_Tech_Nigh_School.Data.Food> Food { get; set; }
    }
}
