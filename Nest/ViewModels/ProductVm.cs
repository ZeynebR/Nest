using Nest.Models;

namespace Nest.ViewModels
{
    public class ProductVm
    {
        public List<Product>  Products { get; set; }
        public List<Category> Categories { get; set; }  
    }
}
