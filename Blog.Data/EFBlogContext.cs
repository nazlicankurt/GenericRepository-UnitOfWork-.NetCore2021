using Blog.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    class EFBlogContext : DbContext
    {
        public EFBlogContext(DbContextOptions<EFBlogContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasOne<Category>(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Article>()
                .HasOne<User>(x => x.User)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.UserId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
