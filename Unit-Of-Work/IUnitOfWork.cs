using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Repositories;
using System;

namespace AmanahTeknologTask.Unit_Of_Work
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository ProductRepository { get; }
        public IInvoiceRepository InvoiceRepository { get; }
        public ITaxRepository TaxRepository { get; }
        public IPayWayRepository<Payway>  PayWayRepository { get; }
        int SaveChanges();
    }
}
