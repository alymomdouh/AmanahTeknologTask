using System;

namespace AmanahTeknologTask.Domains.Models
{
    public class CardInformation
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public string expireDate { get; set; }
        public int? IndividualClientId { get; set; }
        public int? CompanyClientId { get; set; } 
    }
}
