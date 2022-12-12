using System;
using TmpwBlogAPI.Entities;

namespace TmpwBlogAPI.Models
{
	public class PostDTO
	{
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

