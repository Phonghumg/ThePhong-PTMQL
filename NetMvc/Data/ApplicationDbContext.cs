using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetMvc.Models;

namespace NetMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NetMvc.Models.Student> Student { get; set; } = default!;
        public DbSet<NetMvc.Models.Employee> Employee { get; set; } = default!;
        public DbSet<NetMvc.Models.Person> Person { get; set; } = default!;
    }
}
