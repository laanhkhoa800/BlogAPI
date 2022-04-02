
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DataBaseContext : DbContext
    {
            public DataBaseContext() : base("Data Source=DESKTOP-GPNROS1\\SQLEXPRESS;Initial Catalog=BlogAPI;Integrated Security=True")
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

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<PostTag>().HasKey(Pt => new
                {
                    Pt.PostID,
                    Pt.TagID
                });
                modelBuilder.Entity<PostCategory>().HasKey(Pc => new
                {
                    Pc.CategoryID,
                    Pc.PostID
                });
                //ColumnType for User

                modelBuilder.Entity<Post>()
                        .Property(t => t.AuthorID)
                        .IsOptional();
                //FK one to many
                modelBuilder.Entity<Post>()
                .HasRequired<User>(s => s.users)
                .WithMany(g => g.Posts)
                .HasForeignKey<int?>(s => s.AuthorID);




                //FK many to many
                /* modelBuilder.Entity<Post>()
                    .HasMany<Tag>(s => s.Ta)
                    .WithMany(c => c.Posts)
                    .Map(cs =>
                    {
                        cs.MapLeftKey("postId");
                        cs.MapRightKey("tagId");
                        cs.ToTable("post_tag");
                    });*/

                /*   modelBuilder.Entity<Post>()
                      .HasMany<Category>(s => s.Categorys)
                      .WithMany(c => c.Posts)
                      .Map(cs =>
                      {
                          cs.MapLeftKey("postId");
                          cs.MapRightKey("categoryId");
                          cs.ToTable("post_category");
                      });
       */

                modelBuilder.Entity<PostComment>()
               .HasRequired<Post>(s => s.Post)
               .WithMany(g => g.PostComments)
               .HasForeignKey<long?>(s => s.PostID);
                //FK one to many
                modelBuilder.Entity<PostComment>()
                .HasRequired<User>(s => s.User)
                .WithMany(g => g.PostComments)
                .HasForeignKey<long?>(s => s.UserID)
                .WillCascadeOnDelete(false);


            }
        }
}
