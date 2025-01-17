using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP_SISTEMAS_DISTRIBUIDOS_V5.Entities;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TP_SISTEMAS_DISTRIBUIDOS_V5.Entities.Worker> Worker { get; set; } = default!;
    }
