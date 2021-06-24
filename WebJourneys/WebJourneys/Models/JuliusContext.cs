using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebJourneys.Models
{
    public partial class JuliusContext : DbContext
    {
        public JuliusContext()
        {
        }

        public JuliusContext(DbContextOptions<JuliusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=830G6\\SQLEXPRESS;Database=Julius;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Point>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Points", "Travels");

                entity.Property(e => e.IconName).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Longtitude).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PointId).ValueGeneratedOnAdd();

                entity.Property(e => e.Popup).HasMaxLength(400);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Posts", "Travels");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PostId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
