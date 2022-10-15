using AmanahTeknologTask.Dto.Shared;
using System;

namespace AmanahTeknologTask.Dto
{
    public class PaymentVM
    {
        public int Id { get; set; }
        public PaymentCardVM paymentCardVM { get; set; } 
        public PaymentBankVM paymentBankVM { get; set; } 
        public PaymentWay PaymentType { get; set; }
        public DateTime date { get; set; }
        public ClientType ClientType { get; set; }
        public int ProductId { get; set; }
    }
}
