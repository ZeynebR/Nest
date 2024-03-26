using Nest.Models;

namespace Nest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double? Rating { get; set; }
        public decimal SellPrice { get; set; } = default!;
        public decimal? DiscountPrice { get; set; }

        public int VendorId { get; set; }
        public int CategoryId { get; set; } 
        public Category Category { get; set; } = null!;

 
        public Vendor Vendor { get; set; } = null!;

        public List<ProductImage> ProductImages { get; set; } = null!;

    }
}


//assets/imgs/products/apple.jpg
//assets/imgs/products/apple-hover.jpg