namespace Nest.Models
{
    public class Vendor
    {

        public int Id { get; set; } 
        public string Name { get; set; } = null!;   
        public ICollection<Product>? Products { get; set; }


    }
}
