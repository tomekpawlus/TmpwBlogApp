using System;
using Microsoft.AspNetCore.Mvc;
using TmpwBlogAPI.Entities;
using TmpwBlogAPI.Services;

namespace TmpwBlogAPI.Controllers
{
	[Route("api/post")]
	public class PostController : ControllerBase
	{
		private readonly PostService _postService;

		public PostController(PostService postService)
		{
			_postService = postService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Post>> GetAll()
		{
			var posts = _postService.GetAll();
			return Ok(posts);
		}
	}
}

