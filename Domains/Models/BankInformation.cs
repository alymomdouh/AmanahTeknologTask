namespace AmanahTeknologTask.Domains.Models
{
    public class BankInformation
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public int? IndividualClientId { get; set; }
        public int? CompanyClientId { get; set; } 
    }
}
