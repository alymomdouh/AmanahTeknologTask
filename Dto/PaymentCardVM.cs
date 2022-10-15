using AmanahTeknologTask.Dto.Shared;

namespace AmanahTeknologTask.Dto
{
    public class PaymentCardVM
    {
        public int Id { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CardCVC { get; set; }
        public string expireDate { get; set; } 
    }
}
