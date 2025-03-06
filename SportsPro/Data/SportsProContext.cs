using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;

    public class SportProContext : DbContext
    {
        public SportProContext (DbContextOptions<SportProContext> options)
            : base(options)
        {
        }

        public DbSet<SportsPro.Models.Product> Products { get; set; } = default!;
    }
