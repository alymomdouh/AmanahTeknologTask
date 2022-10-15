using System;

namespace AmanahTeknologTask.Dto
{
    public class AddInvoice
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public decimal Totalprice { get; set; }
        public int? TaxId { get; set; }
        public int PaywayId { get; set; }
        public int ProductId { get; set; }
        public int? IndividualClientId { get; set; }
        public int? CompanyClientId { get; set; }
     }
}
