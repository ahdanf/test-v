using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestV.Models;

namespace TestV.Data
{
    public class TestVContext : DbContext
    {
        public TestVContext (DbContextOptions<TestVContext> options)
            : base(options)
        {
        }

        public DbSet<TestV.Models.Employee> Employee { get; set; } = default!;
    }
}
