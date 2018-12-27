using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EXAM3.Models
{
    public class EXAM3Context : DbContext
    {
        public EXAM3Context (DbContextOptions<EXAM3Context> options)
            : base(options)
        {
        }

        public DbSet<EXAM3.Models.Table> Table { get; set; }
    }
}
