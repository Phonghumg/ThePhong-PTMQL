using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetMvc.Models;

namespace NetMvc
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NetMvc.Models.Student> Student { get; set; } = default!;
        public DbSet<NetMvc.Models.Student> Employee { get; set; } = default!;
        
    }
}
