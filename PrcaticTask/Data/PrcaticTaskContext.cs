using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrcaticTask.Models;

namespace PrcaticTask.Data
{
    public class PrcaticTaskContext : DbContext
    {
        public PrcaticTaskContext (DbContextOptions<PrcaticTaskContext> options)
            : base(options)

        {
        }

        public DbSet<PrcaticTask.Models.Brand> Brand { get; set; } = default!;
        public DbSet<PrcaticTask.Models.Model> Model { get; set; } = default!;
    }
}
