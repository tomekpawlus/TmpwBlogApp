using System;
namespace TmpwBlogAPI.Entities
{
	public class Post
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string Content { get; set; }

		public int PostCategoryId { get; set; }
		public virtual PostCategory PostCategory { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }

		public DateTime CreatedDate { get; set; }

	}
}

