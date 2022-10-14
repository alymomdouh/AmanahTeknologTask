using AmanahTeknologTask.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AmanahTeknologTask.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        #region Properties
        protected DataContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }
        #endregion

        #region Constructor
        public BaseRepository(DataContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException("null reference of dbContext");
            DbSet = DbContext.Set<T>(); // this function overiden in the child and return instance
        }
        #endregion

        #region Get All Data Methods
        public virtual IQueryable<T> GetAll()
        {
            return DbSet ;
        }


        public IQueryable<T> GetAllSorted<TKey>(Expression<Func<T, TKey>> sortingExpression)
        {
            return DbSet.OrderBy(sortingExpression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return query;
        }

        public bool GetAny(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = DbSet; 
            bool result = filter != null && query.Any(filter);
            return result;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return DbSet.FirstOrDefault(filter);
            }
            return null;
        }


        #endregion

        #region Get one record
        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual T GetById(long id)
        {
            return DbSet.Find(id);
        }

        #endregion

        #region CRUD Methods
        public virtual void Insert(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public virtual void InsertList(List<T> entityList)
        {
            DbSet.AddRange(entityList);
        }

        public virtual void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
        }

        public virtual void UpdateList(List<T> entityList)
        {
            foreach (T item in entityList)
            {
                Update(item);
            }
        }

        public virtual void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);

        }
        public virtual void DeleteList(List<T> entityList)
        {
            foreach (T item in entityList)
            {
                Delete(item);
            }
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }
        #endregion
    }
}
