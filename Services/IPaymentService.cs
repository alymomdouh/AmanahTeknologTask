using AmanahTeknologTask.Dto;

namespace AmanahTeknologTask.Services
{
    public interface IPaymentService //: IService<PaymentVM, PaymentVM>
    {
        int PaymentByCard(PaymentVM paymentVM);
        int PaymentByBank(PaymentVM paymentVM);
    }
}
