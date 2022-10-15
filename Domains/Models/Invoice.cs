using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AmanahTeknologTask.Domains.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; } 
        public DateTime date { get; set; }
        public decimal Totalprice { get; set; }
        public int? TaxId { get; set; }  
        public int PaywayId { get; set; }  
        public int ProductId { get; set; }  
        public int? IndividualClientId { get; set; }  
        public int? CompanyClientId { get; set; }  
        public IndividualClient IndividualClient { get; set; }  
        public Tax Tax { get; set; }
        public CompanyClient CompanyClient { get; set; }  
        public Payway Payway { get; set; }  
        public Product product { get; set; }

    }
}
