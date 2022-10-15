using System.ComponentModel.DataAnnotations;

namespace AmanahTeknologTask.Domains.Models
{
    public class Tax
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
