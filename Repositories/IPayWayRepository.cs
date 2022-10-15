using AmanahTeknologTask.Domains.Models;
 
namespace AmanahTeknologTask.Repositories
{
    public interface IPayWayRepository<T> where T : class   /// here can make generaic as T OR PUT domain  payway
    {
        void AddPaymentByCard(T entity); 
        void AddPaymentByBank(T entity);
    }
}
