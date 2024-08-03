using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BigBazaarManagementSystemMVC.Models;

namespace BigBazaarDL
{
    public partial class BigBazaarContext : DbContext
    {
        public BigBazaarContext()
        {
        }

        public BigBazaarContext(DbContextOptions<BigBazaarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=Ramakrishna;Initial catalog=BigBazaar;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__17B6DD2628CC5E5C");

                entity.ToTable("Category");

                entity.Property(e => e.CatId).HasColumnName("catID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("catName");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Product__319F67F1BA68FA85");

                entity.ToTable("Product");

                entity.Property(e => e.ProdId).HasColumnName("prodId");

                entity.Property(e => e.CatId).HasColumnName("catId");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("date")
                    .HasColumnName("expDate");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProdCount).HasColumnName("prodCount");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prodName");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Product__catId__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
