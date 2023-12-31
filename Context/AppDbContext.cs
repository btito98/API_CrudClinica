﻿using Clinica.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<Medico> Medico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Habilita o log de dados sensíveis
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
    }
}
