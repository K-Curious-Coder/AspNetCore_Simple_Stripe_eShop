using System.ComponentModel.DataAnnotations;

namespace CoreControllers.ViewModels
{
  public class ProductViewModel
  {
    [Required]
    [Display(Name = "Current Product Id")]
    public int CurrentProductId { get; set; }

    [Required]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; }

    [Required]
    [Display(Name = "Product Description")]
    public string ProductDescription { get; set; }

    [Required]
    [Display(Name = "Product Price")]
    public decimal ProductPrice { get; set; }
  }
}
