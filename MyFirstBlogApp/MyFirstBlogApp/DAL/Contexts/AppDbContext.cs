using Microsoft.EntityFrameworkCore;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Post>().HasKey(i => i.Id);
            modelBuilder.Entity<Post>().HasMany(i => i.Comments).WithOne(i => i.Post).HasForeignKey(i=>i.PostId);
            modelBuilder.Entity<Post>().HasOne(i => i.Category).WithMany(i => i.Posts).HasForeignKey(i => i.CategoryId);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
