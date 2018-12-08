using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RandyPowell.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RandyPowell.Models
{
    public class RandyPowellContext : IdentityDbContext
    {
        public RandyPowellContext (DbContextOptions<RandyPowellContext> options)
            : base(options)
        {
        }

        public DbSet<RandyPowell.Models.Experience> Experience { get; set; }

        public DbSet<RandyPowell.Models.Skill> Skill { get; set; }
    }
}
