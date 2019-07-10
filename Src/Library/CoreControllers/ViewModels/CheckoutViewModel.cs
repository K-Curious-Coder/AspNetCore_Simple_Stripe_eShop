using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreControllers.ViewModels
{
  public class CheckoutViewModel
  {
    [Display(Name = "Select a Colour")]
    public string SelectedColour { get; set; }

    public List<ProductColourViewModel> Colour => new List<ProductColourViewModel>()
    {
      new ProductColourViewModel()
      {
        Id = "Black",
        Colour = "Black"
      },
      new ProductColourViewModel()
      {
        Id = "Steel",
        Colour = "Steel"
      },
      new ProductColourViewModel()
      {
        Id = "Navy",
        Colour = "Navy"
      },
      new ProductColourViewModel()
      {
        Id = "Clear",
        Colour = "Clear"
      }
    };
    public IEnumerable<SelectListItem> GetListOfColours() => this.Colour.Select(item => new SelectListItem()
    {
      Text = item.Colour,
      Value = item.Id.ToString(),
      Selected = item.Id == this.SelectedColour
    });

    [Required(ErrorMessage = "Please select your country region.")]
    [Display(Name = "Country Region")]
    public int CountryZoneId { get; set; }
    public IList<SelectListItem> AvailableCountryZones { get; set; }

    [Required(ErrorMessage = "Required")]
    [Display(Name = "Country")]
    public int CountryId { get; set; }
    public IList<SelectListItem> AvailableCountries { get; set; }

    [Display(Name = "Product Quantity")]
    public int ProductQuantity { get; set; }

    public ProductViewModel ProductViewModel { get; set; }
    public CustomerViewModel CustomerViewModel { get; set; }

    public CheckoutViewModel()
    {
      this.AvailableCountryZones = new List<SelectListItem>();

      this.AvailableCountries = new List<SelectListItem>();

      this.ProductViewModel = new ProductViewModel();

      this.CustomerViewModel = new CustomerViewModel();
    }
  }
}

