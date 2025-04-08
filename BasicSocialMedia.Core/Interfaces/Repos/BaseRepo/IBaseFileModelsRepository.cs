﻿using System.Linq.Expressions;

namespace BasicSocialMedia.Core.Interfaces.Repos.BaseRepo
{
	public interface IBaseFileModelsRepository<T> : IBaseRepository<T> where T : class
	{
		Task<IEnumerable<T?>> GetAllAsync(Expression<Func<T, bool>> matcher);
	}
}
