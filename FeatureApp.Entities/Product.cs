using Entities;
using System.ComponentModel.DataAnnotations;

namespace FeatureApp.Entities
{
    public class Product : EntityBase
    {
        [Required]
        public string Sku { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string? Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}