using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Nest.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Nest.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Icon { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } 
        public List<Product>? Products { get; set; } 
    }
}
///assets/imgs/theme/icons/category-1.svg
//    assets/imgs/products/apple.jpg