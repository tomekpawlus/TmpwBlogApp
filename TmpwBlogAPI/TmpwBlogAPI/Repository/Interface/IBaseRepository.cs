using System;
using TmpwBlogAPI.Entities;

namespace TmpwBlogAPI.Repository.Interface
{
	public interface IBaseRepository<T, K> where T:BaseEntity
	{
		Task<List<T>> GetAll();
		IQueryable<T> Find();
		Task<T> Get(K id);
		Task<T> Add(T entity);
        Task<T> Delete(K id);
        Task<T> Update(T entity);
	}
}

