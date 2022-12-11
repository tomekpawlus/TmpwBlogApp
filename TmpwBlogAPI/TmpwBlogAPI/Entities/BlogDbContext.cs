using System;
using Microsoft.EntityFrameworkCore;

namespace TmpwBlogAPI.Entities
{
	public class BlogDbContext : DbContext
	{
		private readonly string _connectionString=
            @"
  Server=localhost,1433;
  Database=TmpwBlogDb;
  User Id=SA;
  Password=12345OHdf%e;
  TrustServerCertificate=True";

		public DbSet<Post> Posts { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<PostCategory> PostsCategories {get; set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Post>(eb =>
			{
				eb.Property(x => x.Title).IsRequired();
				eb.Property(x => x.Content).IsRequired();
			});  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

