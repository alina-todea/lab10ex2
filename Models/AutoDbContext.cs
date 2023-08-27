using System;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Lab10ex2.Models
{
	internal class AutoDbContext : DbContext
	{
        public DbSet<Car> Cars { get; set; }
        public DbSet<Producer> Producers { get; set; }


        public AutoDbContext()
		{
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=postgres;Database='Lab10ex2'");

    }
}


