using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint06
{
    public class SpaceContext : DbContext 
    {
        public DbSet<Spaceship> Spaceship { get; set; }
        public DbSet<Ravioli> Ravioli { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Checkpoint06;");
            }
        }
    }
}
