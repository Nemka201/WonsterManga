using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace Viajeros.Data.Context
{
    public partial class WonsterContext : DbContext
    {
        public WonsterContext() { }
        public WonsterContext(DbContextOptions<WonsterContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=BENAME\\SQLEXPRESS;Initial Catalog=wonsterContext;Integrated Security=True; TrustServerCertificate=True;");
            }
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategorySerie> CategorySeries { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<ChapterPage> ChapterPages { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Languajes> Languajes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<SerieState> SerieStates { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volume> Volumes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategorySerie>()
              .HasKey(cs => new { cs.SerieId, cs.CategoryId });

            modelBuilder.Entity<CategorySerie>()
              .HasOne(cs => cs.Serie)
              .WithMany(s => s.Categories)
              .HasForeignKey(cs => cs.SerieId);

            modelBuilder.Entity<CategorySerie>()
              .HasOne(cs => cs.Category)
              .WithMany(c => c.Series)
              .HasForeignKey(cs => cs.CategoryId);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
