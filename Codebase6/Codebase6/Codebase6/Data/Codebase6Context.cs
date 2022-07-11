using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebase6.Model;

namespace Codebase6.Data
{
    public class Codebase6Context : DbContext
    {
        public Codebase6Context (DbContextOptions<Codebase6Context> options)
            : base(options)
        {
        }

        public DbSet<Codebase6.Model.Employee>? Employee { get; set; }
    }
}
