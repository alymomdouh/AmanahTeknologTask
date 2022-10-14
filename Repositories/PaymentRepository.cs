using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;
using System.Collections.Generic;
using System.Linq;

namespace AmanahTeknologTask.Repositories
{
    public class PaymentRepository: BaseRepository<Payway>
    {
        public PaymentRepository(DataContext db) : base(db)
        {

        }

        public List<Payway> GetAllPayment()
        {
            return GetAll().ToList();
        }

        public void InsertPayment(Payway Payment)
        {
              Insert(Payment);
        }
        public void UpdatePayment(Payway Payment)
        {
            Update(Payment);
        }
        public void DeletePayment(int id)
        {
            Delete(id);
        }

        public bool CheckPaymentExists(Payway Payment)
        {
            return GetAny(b => b.Id == Payment.Id);
        }
        public Payway GetPaymentById(int payment)
        {
            return GetFirstOrDefault(b => b.Id == payment);
        }
    }
}
