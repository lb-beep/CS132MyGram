using System;
using CS132MyGram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable
namespace CS132MyGram.MyGramContext
{
    public partial class MYGRAMCONTEXT : DbContext
    {
        public MYGRAMCONTEXT()
        {
        }

        public MYGRAMCONTEXT(DbContextOptions<MYGRAMCONTEXT> options)
            : base(options)
        {
        }
        public virtual DbSet<Image> ImageId { get; set; }
        public virtual DbSet<Image> ImageName { get; set; }
        public virtual DbSet<Image> ImagePath { get; set; }
        public virtual DbSet<Image> ImageDescription { get; set; }
        public virtual DbSet<Image> ImageAltText { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>(entity =>
            {

                entity.ToTable("IMAGE", "MYGRAM");

                entity.HasIndex(e => e.ImageName, "ImageName").IsUnique();

                entity.Property(e => e.ImageId).HasDefaultValueSql("'10'");

                entity.Property(e => e.ImageDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'DESCRIPTION TEST'");


                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'PRODUCT NAME TEST'");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder); 


    }
}
