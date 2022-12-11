using System;
using TmpwBlogAPI.Entities;

namespace TmpwBlogAPI.Seeder
{
    public class PostSeeder
    {
        private readonly BlogDbContext _blogDbContext;

        public PostSeeder(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public void Seed()
        {
            if (_blogDbContext.Database.CanConnect())
            {
                var posts = GetPosts();
                _blogDbContext.Posts.AddRange(posts);
                _blogDbContext.SaveChanges();
            }
        }

        private IEnumerable<Post> GetPosts()
        {
            var posts = new List<Post> {
                new Post
                {
                    Title = "Lorem Ipsum is simply dummy",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                    "when an unknown printer took a galley of type and scrambled it to make a type specimen " +
                    "book. It has survived not only five centuries, but also the leap into " +
                    "electronic typesetting, remaining essentially unchanged. It was popularised " +
                    "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including " +
                    "versions of Lorem Ipsum.",
                    PostCategory = new PostCategory
                    {
                        
                        Name="Programowanie",
                    },
                    User = new User
                    {
                        
                        Name="Tomek",
                        Email="tmkpawlus@gmail.com"
                    },
                    CreatedDate = DateTime.Now,
                }
            };
            return posts;
        }
    }
}

