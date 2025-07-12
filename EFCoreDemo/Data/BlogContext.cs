using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Models.Article> Articles { get; set; } = null!;
        public DbSet<Models.Category> Categories { get; set; } = null!;
        public DbSet<Models.Comment> Comments { get; set; } = null!;
        public DbSet<Models.Author> Authors { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TCHAPS-PF409VV8;Database=ArticleEFDemo;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Article>()
                .HasOne(a => a.Category)
                .WithMany(c => c.Articles)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Models.Article>()
                .HasOne(a => a.Author)
                .WithMany(au => au.Articles)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<Models.Comment>()
                .HasOne(c => c.Article)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.ArticleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Models.Comment>()
                .HasOne(c => c.Author)
                .WithMany(au => au.Comments)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
