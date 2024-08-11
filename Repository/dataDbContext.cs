using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using cmpg323project2.Repository.Models;

namespace cmpg323project2.Repository
{
    public partial class dataDbContext : DbContext
    {
        public dataDbContext()
        {
        }

        public dataDbContext(DbContextOptions<dataDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<JobTelemetry> JobTelemetries { get; set; } = null!;
        public virtual DbSet<Process> Processes { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=cmpg323project2server.database.windows.net;Initial Catalog=cmpg323project2database;User ID=CloudSAc467ee52;Password=Kingmeka33*;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).ValueGeneratedNever();
            });

            modelBuilder.Entity<JobTelemetry>(entity =>
            {
                entity.Property(e => e.EntryDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExcludeFromTimeSaving).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.Property(e => e.ProcessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateSubmitted).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultBusinessFunction).HasDefaultValueSql("('Unspecified')");

                entity.Property(e => e.DefaultGeography).HasDefaultValueSql("('Global')");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProjectCreationDate).HasDefaultValueSql("(dateadd(hour,(2),getdate()))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
