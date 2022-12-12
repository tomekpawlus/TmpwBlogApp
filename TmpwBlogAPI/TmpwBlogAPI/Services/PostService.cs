using System;
using TmpwBlogAPI.Entities;
using TmpwBlogAPI.Repository.Interface;

namespace TmpwBlogAPI.Services
{
	public class PostService
	{
		private readonly IPostRepository _postRepository;

		public PostService(IPostRepository postRepository)
		{
			_postRepository = postRepository;
		}


		public async Task<IEnumerable<Post>> GetAll()
		{
			return await _postRepository.GetAll();
		}

	}
}

