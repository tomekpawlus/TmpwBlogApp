using System;
namespace TmpwBlogAPI.Entities
{
	public class PostCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Post> Posts { get; set; }
	}
}

