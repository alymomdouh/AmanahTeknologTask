using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Repositories;

namespace AmanahTeknologTask.Unit_Of_Work
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        public IProductRepository ProductRepository { get; }
        public IInvoiceRepository InvoiceRepository { get; }
        public ITaxRepository TaxRepository { get; }
        public IPayWayRepository<Payway> PayWayRepository { get; }
        public UnitOfWork(DataContext context)
        {
            this.context = context;
            ProductRepository = new ProductRepository(this.context);
            InvoiceRepository = new InvoiceRepository(this.context);
            TaxRepository = new TaxRepository(this.context);
            PayWayRepository = new PayWayRepository(this.context);
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
