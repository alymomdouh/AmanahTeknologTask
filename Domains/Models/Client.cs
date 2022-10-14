using System.Collections.Generic;

namespace AmanahTeknologTask.Domains.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }    
         public string Email { get; set; }
        public ICollection< CardInformation> CardInformation { get; set; }
        public ICollection<BankInformation> BankInformation { get; set; }
    }
}
