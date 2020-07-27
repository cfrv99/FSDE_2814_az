using EFCore1.Models;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }


        public override int SaveChanges()
        {

  //          var addedAuditedEntities = ChangeTracker.Entries<IAuditedEntity>()
  //.Where(p => p.State == EntityState.Added)
  //.Select(p => p.Entity);

  //          var modifiedAuditedEntities = ChangeTracker.Entries<IAuditedEntity>()
  //            .Where(p => p.State == EntityState.Modified)
  //            .Select(p => p.Entity);

  //          var now = DateTime.UtcNow;

  //          foreach (var added in addedAuditedEntities)
  //          {
  //              added.CreatedAt = now;
  //              added.LastModifiedAt = now;
  //          }

  //          foreach (var modified in modifiedAuditedEntities)
  //          {
  //              modified.LastModifiedAt = now;
  //          }

  //          return base.SaveChanges();

            return base.SaveChanges();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(i => i.Id);

            modelBuilder.Entity<Category>().HasOne<Post>(i => i.Post).WithOne(i => i.Category);

            modelBuilder.Entity<Comment>()
                .HasOne<Post>(i => i.Post)
                .WithMany(i => i.Comments)
                .HasForeignKey(i => i.PostId)
                .OnDelete(DeleteBehavior.Cascade);


            //many-to-many

            modelBuilder.Entity<UserSkills>()
                .HasKey(i => new { i.UserId, i.SkillId });
            modelBuilder.Entity<UserSkills>()
                .HasOne(i => i.Skill)
                .WithMany(i => i.UserSkills)
                .HasForeignKey(i => i.SkillId);
            modelBuilder.Entity<UserSkills>()
                .HasOne(i => i.User)
                .WithMany(i => i.UserSkills)
                .HasForeignKey(i => i.UserId);


            //
            modelBuilder.Entity<Post>()
                .HasMany<Comment>(i => i.Comments)
                .WithOne(i => i.Post)
                .HasForeignKey(i => i.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
    }
}
