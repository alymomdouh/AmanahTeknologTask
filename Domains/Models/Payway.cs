using System;
using System.ComponentModel.DataAnnotations;

namespace AmanahTeknologTask.Domains.Models
{
    public class Payway
    {
        [Key]
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int? CardInformationId { get; set; }
        public int? BankInformationId { get; set; }
        public CardInformation CardInformation { get; set; }
        public BankInformation BankInformation { get; set; }
    }
}
