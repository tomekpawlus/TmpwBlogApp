using System;
namespace TmpwBlogAPI.Repository.Interface
{
	public interface IBaseRepository<T>
	{
		List<T> GetAll();
		T Get();
		void Add(T t);
		void Delete(int id);
		void Update(T t);
	}
}

