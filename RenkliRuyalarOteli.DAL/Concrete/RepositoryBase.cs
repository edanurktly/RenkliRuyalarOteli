﻿using Microsoft.EntityFrameworkCore;
using RenkliRuyalarOteli.DAL.Abstract;
using RenkliRuyalarOteli.DAL.Contexts;
using RenkliRuyalarOteli.Entities.Entites.Abstarct;
using System.Linq.Expressions;

namespace RenkliRuyalarOteli.DAL.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, new()
    {
        public RepositoryBase()
        {
            DbContext = new SqlDbContext();
        }
        public virtual Task<int> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> FindAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ICollection<T>> RawSqlQuery(T entity, string sql)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}