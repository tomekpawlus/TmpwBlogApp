using System;
using TmpwBlogAPI.Entities;
using TmpwBlogAPI.Repository.Interface;

namespace TmpwBlogAPI.Repository.Impl
{
	public class BaseRepostitory<T> : IBaseRepository<T>
	{
        private readonly BlogDbContext _blogDbContext;

		public BaseRepostitory(BlogDbContext blogDbContext)
		{
            _blogDbContext = blogDbContext;
		}

        public void Add(T t)
        {
            
        }

        public void Delete(int id)
        {

        }

        public T Get()
        {
           
        }

        public List<T> GetAll()
        {

        }

        public void Update(T t)
        {

        }
    }
}

