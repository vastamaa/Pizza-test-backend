using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApiEF_react_termekek.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Termekek> Termekek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=termekek;user=root;password=;SSL mode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Termekek>(entity =>
            {
                entity.ToTable("termekek");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Kép)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("kép");

                entity.Property(e => e.Leírás)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("leírás");

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("név");

                entity.Property(e => e.Ár)
                    .HasColumnType("int(11)")
                    .HasColumnName("ár");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
