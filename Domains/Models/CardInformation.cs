using System;

namespace AmanahTeknologTask.Domains.Models
{
    public class CardInformation
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CardNumber { get; set; }
        public int CCV { get; set; }
        public DateTime expireDate { get; set; }
        public int? IndividualClientId { get; set; }
        public int? CompanyClientId { get; set; }
        public IndividualClient IndividualClient { get; set; }
        public CompanyClient CompanyClient { get; set; }
    }
}
