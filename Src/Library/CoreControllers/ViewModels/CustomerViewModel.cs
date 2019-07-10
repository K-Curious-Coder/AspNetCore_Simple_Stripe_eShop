using System.ComponentModel.DataAnnotations;

namespace CoreControllers.ViewModels
{
  public class CustomerViewModel
  {
    public CustomerViewModel() => this.PostalAddressViewModel = new PostalAddressViewModel();

    [Required(ErrorMessage = "Required")]
    [Display(Name = "Full Name")]
    public string TitleAndFullName { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Required")]
    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email")]
    public string Email { get; set; }

    public PostalAddressViewModel PostalAddressViewModel { get; set; }
  }
}
