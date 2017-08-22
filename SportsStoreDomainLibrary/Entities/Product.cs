using System.ComponentModel.DataAnnotations;

namespace SportsStoreDomainLibrary.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Product Name"),Required(ErrorMessage = "Please Enter a Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public string Category { get; set; }
    }
}
