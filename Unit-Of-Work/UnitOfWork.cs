using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Repositories;

namespace AmanahTeknologTask.Unit_Of_Work
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        public IProductRepository ProductRepository { get; }
        public UnitOfWork(DataContext context)
        {
            this.context = context;
            ProductRepository = new ProductRepository(this.context); 
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
