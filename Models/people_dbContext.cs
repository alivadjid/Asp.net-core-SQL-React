using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrudWithReactAspNetCore.Models
{
    public partial class people_dbContext : DbContext
    {
        public people_dbContext()
        {
        }

        public people_dbContext(DbContextOptions<people_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Peoples> Peoples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local)\\;Database=people_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peoples>(entity =>
            {
                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Dekret)
                    .HasColumnName("dekret")
                    .HasMaxLength(3);

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
