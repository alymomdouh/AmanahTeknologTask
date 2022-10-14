using System.ComponentModel.DataAnnotations;

namespace AmanahTeknologTask.Domains.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
