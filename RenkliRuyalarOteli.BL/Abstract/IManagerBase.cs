﻿using RenkliRuyalarOteli.Entities.Entites.Abstarct;
using System.Linq.Expressions;

namespace RenkliRuyalarOteli.BL.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity, new()
    {

        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);

        Task<T> GetByIdAsync(string id);
        Task<T> FindAsync(Expression<Func<T, bool>> filter = null);

        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null);

        Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null
            , params Expression<Func<T, object>>[] include);

        Task<ICollection<T>> RawSqlQuery(T entity, string sql);
    }
}