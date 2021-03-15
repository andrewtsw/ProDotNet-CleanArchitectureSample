using CleanArchitecture.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Entities
{
    public class Product : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
    }
}
