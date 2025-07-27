using System.ComponentModel.DataAnnotations;

namespace CarAssetApp.Models
{
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        public string ModelName { get; set; } = null!;

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public string CarNumber { get; set; } = null!;
    }
}
