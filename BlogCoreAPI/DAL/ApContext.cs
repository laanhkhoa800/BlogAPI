using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Reponsitorys
{
    public class ApContext : DbContext
    {
        public ApContext(DbContextOptions<ApContext> options) : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostMeta> postMetas { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            //Fluent API For User
            modelBuilder.Entity<User>().HasKey(u => u.UserID);
            modelBuilder.Entity<User>().Property(u => u.UserID).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasDefaultValue(null);
            modelBuilder.Entity<User>().Property(u => u.MiddleName).HasDefaultValue(null);
            modelBuilder.Entity<User>().Property(u => u.LastName).HasDefaultValue(null);
            modelBuilder.Entity<User>().HasIndex(u => u.Mobile).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Mobile).HasMaxLength(15);
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.PassWord).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Registered).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.LastLogin).HasDefaultValue(null);
            modelBuilder.Entity<User>().Property(u => u.InTro).HasDefaultValue(null);
            modelBuilder.Entity<User>().Property(u => u.Profile).HasDefaultValue(null);

            //Fluent API For Post
            modelBuilder.Entity<Post>().HasKey(p => p.PostID);
            modelBuilder.Entity<Post>().Property(p => p.PostID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Post>().Property(p => p.AuthorID).IsRequired();
            modelBuilder.Entity<Post>().Property(p => p.ParentID).HasDefaultValue(null);
            modelBuilder.Entity<Post>().Property(p => p.Title).IsRequired().HasMaxLength(75);
            modelBuilder.Entity<Post>().Property(p => p.MetaTile).HasMaxLength(100);
            modelBuilder.Entity<Post>().HasIndex(p => p.Slug).IsUnique();
            modelBuilder.Entity<Post>().Property(p => p.Slug).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Post>().Property(p => p.PubLished).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Post>().Property(p => p.CreateAT).IsRequired();
            modelBuilder.Entity<Post>().Property(p => p.UpdateAT).HasDefaultValue(null);
            modelBuilder.Entity<Post>().Property(p => p.PublishedAT).HasDefaultValue(null);
            modelBuilder.Entity<Post>().Property(p => p.Content).HasDefaultValue(null);

            // Foreign_Key
            modelBuilder.Entity<Post>().HasOne<User>(p => p.users).WithMany(u => u.Posts).HasForeignKey(p => p.AuthorID);

            modelBuilder.Entity<PostTag>().HasKey(Pt => new
            {
                Pt.PostID,
                Pt.TagID
            });
            modelBuilder.Entity<PostComment>().HasKey(Pt => new
            {
                Pt.PostCommentID,
            });
            modelBuilder.Entity<PostCategory>().HasKey(Pc => new
            {
                Pc.CategoryID,
                Pc.PostID
            });
        }
    }
}
