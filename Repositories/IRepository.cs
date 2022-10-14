using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AmanahTeknologTask.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "");

        T GetById(int id);

        void Insert(T entity);
        void InsertList(List<T> entities);

        void Update(T entity);
        void UpdateList(List<T> entities);

        void Delete(T entity);
        void DeleteList(List<T> entities);


    }
}
