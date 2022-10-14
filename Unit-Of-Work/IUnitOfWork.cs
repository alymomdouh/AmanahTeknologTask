using AmanahTeknologTask.Repositories;
using System;

namespace AmanahTeknologTask.Unit_Of_Work
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository ProductRepository { get; }
        int SaveChanges();
    }
}
