using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;
using System;

namespace AmanahTeknologTask.Repositories
{
    public class PayWayRepository : IPayWayRepository<Payway>
    {
        protected DataContext DbContext { get; set; }

        public PayWayRepository(DataContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException("null reference of dbContext");
        }
        public void AddPaymentByBank(Payway entity)
        {
            DbContext.Add<Payway>(entity); 
        }

        public void AddPaymentByCard(Payway entity)
        {
            DbContext.Add<Payway>(entity);
            ////// this for save time of task i create here invoice without create new servce and repostry for invoice 
            
        }
    }
}
