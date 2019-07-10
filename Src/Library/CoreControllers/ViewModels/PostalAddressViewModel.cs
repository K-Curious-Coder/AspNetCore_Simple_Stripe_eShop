using System.ComponentModel.DataAnnotations;

namespace CoreControllers.ViewModels
{
  public class PostalAddressViewModel
  {
    [Required(ErrorMessage = "Required")]
    [Display(Name = "City, State or Town")]
    public string City { get; set; }

    [Required(ErrorMessage = "Required")]
    [Display(Name = "Address")]
    public string Address1 { get; set; }

    [Required(ErrorMessage = "Required")]
    [Display(Name = "Postal or ZipCode")]
    [DataType(DataType.PostalCode)]
    public string PostOrZipCode { get; set; }
  }
}
