using System;
using Microsoft.EntityFrameworkCore;
using TmpwBlogAPI.Entities;
using TmpwBlogAPI.Repository.Interface;

namespace TmpwBlogAPI.Repository.Impl
{
	public abstract class BaseRepostitory<T, K> : IBaseRepository<T, K> where T:BaseEntity
	{
        private readonly BlogDbContext context;
        private readonly DbSet<T> _dbSet;

        #region Constructor
        public BaseRepostitory(BlogDbContext context)
		{
            this.context = context;
            _dbSet = this.context.Set<T>();
		}
        #endregion

        #region Public Methods
        public virtual async Task<T> Add(T entity)
        {
            _dbSet.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Delete(K id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return entity;
            }
            _dbSet.Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public virtual IQueryable<T> Find()
        {
            return _dbSet;
        }

        public virtual async Task<T> Get(K id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
        #endregion
    }
}

