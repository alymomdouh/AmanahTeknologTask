using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AmanahTeknologTask.Repositories
{
    public class InvoiceRepository :BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DataContext _context) : base(_context)
        {
        }

        public void Insert(Invoice entity)
        {
            DbContext.Set<Invoice>().Add(entity);
        }
        public void Delete(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteList(List<Invoice> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Invoice GetById(int id)
        {
          return  DbContext.Set<Invoice>().Find(id);
        }

        public IQueryable<Invoice> GetWhere(Expression<Func<Invoice, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<Invoice> query = DbContext.Set<Invoice>();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return query;
        }
        
        public void InsertList(List<Invoice> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateList(List<Invoice> entities)
        {
            throw new NotImplementedException();
        }
    }
}
