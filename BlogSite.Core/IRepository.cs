using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlogSite.Core
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Save();
    }
}
