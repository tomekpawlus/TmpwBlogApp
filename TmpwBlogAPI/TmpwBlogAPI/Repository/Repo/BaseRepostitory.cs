using System;
using Microsoft.EntityFrameworkCore;
using TmpwBlogAPI.Entities;
using TmpwBlogAPI.Repository.Interface;

namespace TmpwBlogAPI.Repository.Impl
{
	public abstract class BaseRepostitory<T, K> : IBaseRepository<T, K> where T:BaseEntity
	{
        private readonly BlogDbContext _blogDbContext;
        private readonly DbSet<T> _dbSet;

        #region Constructor
        public BaseRepostitory(BlogDbContext blogDbContext)
		{
            _blogDbContext = blogDbContext;
            _dbSet = this._blogDbContext.Set<T>();
		}
        #endregion

        #region Public Methods
        public virtual async Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Delete(K id)
        {
            throw new NotImplementedException();
        }

        public virtual async IQueryable<T> Find()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Get(K id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

