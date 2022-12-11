using System;
using Microsoft.AspNetCore.Mvc;
using TmpwBlogAPI.Entities;

namespace TmpwBlogAPI.Controllers
{
	[Route("api/post")]
	public class PostController
	{
		public PostController()
		{

		}
		public ActionResult<IEnumerable<Post>> GetAll()
		{




		}
	}
}

