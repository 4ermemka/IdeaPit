using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IdeaPit
{
    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
        }

        public virtual DbSet<Commentary> Commentary { get; set; }
        public virtual DbSet<Idea> Idea { get; set; }
        public virtual DbSet<IdeaTag> IdeaTag { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentary>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Idea>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Idea>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Idea>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Idea>()
                .HasMany(e => e.Commentary)
                .WithRequired(e => e.Idea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idea>()
                .HasMany(e => e.IdeaTag)
                .WithRequired(e => e.Idea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idea>()
                .HasMany(e => e.Post)
                .WithRequired(e => e.Idea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagName)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.IntCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.IdeaTag)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserBIO)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Commentary)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Post)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
