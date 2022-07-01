using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MenuMasterAPI.Models
{
    public partial class MenuMasterContext : DbContext
    {
        public MenuMasterContext()
        {
        }

        public MenuMasterContext(DbContextOptions<MenuMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataMenuMaster> DataMenuMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataMenuMaster>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("DataMenuMaster");

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAkhir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAwal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
