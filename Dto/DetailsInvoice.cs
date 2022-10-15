using System;

namespace AmanahTeknologTask.Dto
{
    public class DetailsInvoice
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public decimal Totalprice { get; set; }
        public int? TaxId { get; set; }
        public int PaywayId { get; set; }
        public int ProductId { get; set; }
        public int? IndividualClientId { get; set; }
        public int? CompanyClientId { get; set; }
        public ListIndividualClient? IndividualClient { get; set; }
        public DetailsTax? Tax { get; set; }
        public ListCompanyClient? CompanyClient { get; set; }
        public PaymentVM Payway { get; set; }
        public ListProduct product { get; set; }
    }
}
