using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ProductDto : BaseDto
    {
        [Required]
        public string Sku { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsNew { get; set; }
    }
}