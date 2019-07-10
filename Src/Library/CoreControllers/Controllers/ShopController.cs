using System;
using System.Linq;
using System.Threading.Tasks;

using CoreControllers.ViewModels;

using CoreDomainFeature;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreControllers.Controllers
{
  public abstract class ShopController : ShopBaseController
  {
    public IUnitOfWork UnitOfWork;

    protected ShopController(IUnitOfWork unitOfWork, IOptionsFactory appSettings) : base(appSettings) => this.UnitOfWork = unitOfWork;

    private decimal GetProductPrice(CheckoutViewModel model) => model.ProductViewModel.ProductPrice;

    protected async Task SetSessionPaymentData(CheckoutViewModel model)
    {
      this.TempData.Keep();

      var currentProductPrice = this.GetProductPrice(model: model);
      var currentProductQuantity = this.GetProductQuantity(model: model);
      var currentShippingCost = this.GetCurrentShippingCost(shippingCost: await this.GetShippingCost(model: model), productQuantity: currentProductQuantity);
      var total = this.GetIotal(productPrice: currentProductPrice, productQuantity: currentProductQuantity, shippingCost: currentShippingCost);

      this.TempData["ProductName"] = model.ProductViewModel.ProductName;

      this.TempData["ProductDescription"] = model.ProductViewModel.ProductDescription;

      this.TempData["UserFeedbackBuyPageProductPrice"] = currentProductPrice.ToString();//!!!

      this.TempData["BuyProduct_ProductPrice"] = currentProductPrice.ToString();//!!!

      var ddd = this.TempData["BuyProduct_ProductPrice"].ToString();

      this.TempData["UserFeedbackBuyPageShippingCost"] = currentShippingCost.ToString();

      this.TempData["UserFeedbackBuyPageProductQuantity"] = currentProductQuantity.ToString();
      this.TempData["UserFeedbackThanksProductQuantity"] = currentProductQuantity.ToString();

      var currentTotalCost = ((int)Math.Floor(total * 100)).ToString();
      this.TempData["TotalCostGet"] = currentTotalCost;
      this.TempData["TotalCostPost"] = currentTotalCost;

      this.TempData["UserFeedbackBuyPageTotalCost"] = total.ToString();

      this.TempData["Email"] = total.ToString();
      this.TempData["TitleAndFullName"] = model.CustomerViewModel.TitleAndFullName;
      this.TempData["EmailSubject"] = $"Purchase of {model.ProductViewModel.ProductName}";
      this.TempData["EmailBody"] = $"Purchase of {model.ProductViewModel.ProductName} by {model.CustomerViewModel.TitleAndFullName} - Customer email: {model.CustomerViewModel.Email}";

      if(model.SelectedColour != null)
      {
        this.TempData["SelectedColour"] = model.SelectedColour;
      }
      else
      {
        var randomNumber = new Random();
        string[] colours = { "Black", "Steel", "Navy", "Clear" };
        var index = randomNumber.Next(0, colours.Length);
        this.TempData["SelectedColour"] = colours[index];
      }

      this.TempData["UserFeedbackThanksProductPrice"] = currentProductPrice.ToString();
      this.TempData["UserFeedbackThanksCurrentPostageRate"] = currentShippingCost.ToString();
      this.TempData["UserFeedbackThanksTotalCost"] = total.ToString();

      this.TempData.Keep();
    }

    protected async Task OnPostSetTempDataForCheckoutThanks(CheckoutViewModel model)
    {
      var currentProductPrice = this.GetProductPrice(model: model);
      var currentProductQuantity = this.GetProductQuantity(model: model);
      var currentShippingCost = await this.GetShippingCost(model: model);
      var total = this.GetIotal(productPrice: currentProductPrice, productQuantity: currentProductQuantity, shippingCost: currentShippingCost);
      this.TempData["ProductNameTempData_Post"] = model.ProductViewModel.ProductName;
      this.TempData["ProductDescriptionTempData_Post"] = model.ProductViewModel.ProductDescription;
      this.TempData["ProductPriceTempData_Post"] = currentProductPrice.ToString();
      this.TempData["ShippingCostTempData_Post"] = currentShippingCost.ToString();
      this.TempData["ProductQuantityTempData_Post"] = currentProductQuantity.ToString();
      this.TempData["TotalCostTempData_Post"] = ((int)Math.Floor(total * 100)).ToString();
      this.TempData["UserFeedbackTotalCostTempData_Post"] = total.ToString();
      this.TempData["CustomerEmailTempData_Post"] = model.CustomerViewModel.Email;
      this.TempData["TitleAndFullNameTempData_Post"] = model.CustomerViewModel.TitleAndFullName;
      this.TempData["EmailSubjectTempData_Post"] = $"Purchase of {model.ProductViewModel.ProductName}";
      this.TempData["EmailBodyTempData_Post"] = $"Purchase of {model.ProductViewModel.ProductName} by {model.CustomerViewModel.TitleAndFullName} - Customer email: {model.CustomerViewModel.Email}";

      if(model.SelectedColour != null)
      {
        this.TempData["SelectedColourTempData_Post"] = model.SelectedColour;
      }
      else
      {
        var randomNumber = new Random();
        string[] colours = { "Black", "Steel", "Navy", "Clear" };
        var index = randomNumber.Next(0, colours.Length);
        this.TempData["SelectedColourTempData_Post"] = colours[index];
      }

      this.TempData["UserFeedbackThanksProductPriceTempData_Post"] = currentProductPrice.ToString();
      this.TempData["UserFeedbackThanksCurrentPostageRateTempData_Post"] = currentShippingCost.ToString();
      this.TempData["UserFeedbackThanksTotalCostTempData_Post"] = total.ToString();
    }

    protected virtual async Task<CheckoutViewModel> OnGetCheckoutData(int theSelectedProduct)
    {
      var model = new CheckoutViewModel();

      model.AvailableCountryZones.Add(new SelectListItem { Text = "Select Your Country Region", Value = string.Empty });

      //var countryZoneList = await this.CountryZoneRepository.GetAllCountryZonesAsync();
      var countryZoneList = await this.UnitOfWork.CountryZoneRepository.GetAllCountryZonesAsync();

      foreach(var countryZone in countryZoneList)
      {
        model.AvailableCountryZones.Add(new SelectListItem
        {
          Text = countryZone.CountryZoneName,
          Value = countryZone.Id.ToString()
        });
      }

      //var productDataList = await this.ProductRepository.GetAllAsync();
      var productDataList = await this.UnitOfWork.ProductRepository.GetAllAsync();

      model.ProductViewModel.ProductName = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductName;
      model.ProductViewModel.ProductDescription = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductDescription;
      model.ProductViewModel.ProductPrice = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductPrice;

      model.AvailableCountries.Add(new SelectListItem { Text = "Countries Will Show Here", Value = string.Empty });

      return model;
    }

    protected virtual async Task<CheckoutViewModel> OnPostCheckoutData(CheckoutViewModel model, int theSelectedProduct)
    {
      model.AvailableCountryZones.Add(new SelectListItem { Text = "Select Your Country Region", Value = string.Empty });

      //var countryZoneList = await this.CountryZoneRepository.GetAllCountryZonesAsync();
      var countryZoneList = await this.UnitOfWork.CountryZoneRepository.GetAllCountryZonesAsync();

      foreach(var countryZone in countryZoneList)
      {
        model.AvailableCountryZones.Add(new SelectListItem
        {
          Text = countryZone.CountryZoneName,
          Value = countryZone.Id.ToString()
        });
      }

      //var productDataList = await this.ProductRepository.GetAllAsync();
      var productDataList = await this.UnitOfWork.ProductRepository.GetAllAsync();

      model.ProductViewModel.ProductName = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductName;
      model.ProductViewModel.ProductDescription = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductDescription;
      model.ProductViewModel.ProductPrice = productDataList.FirstOrDefault(item => item.CurrentProductId == theSelectedProduct).ProductPrice;

      model.AvailableCountries.Add(new SelectListItem { Text = "Countries Will Show Here", Value = string.Empty });

      return model;
    }

    protected CheckoutThanksViewModel GetCheckoutThanksData()
    {
      this.TempData.Keep();

      var model = new CheckoutThanksViewModel
      {
        ProductName = this.GetStringValueFromTempData(value: "ProductName"),
        UserFeedbackBuyPageProductPrice = this.GetStringValueFromTempData(value: "UserFeedbackBuyPageProductPrice"),
        UserFeedbackThanksProductQuantity = this.GetStringValueFromTempData(value: "UserFeedbackThanksProductQuantity"),
        UserFeedbackBuyPageShippingCost = this.GetStringValueFromTempData(value: "UserFeedbackBuyPageShippingCost"),
        UserFeedbackBuyPageTotalCost = this.GetStringValueFromTempData(value: "UserFeedbackBuyPageTotalCost"),
        TitleAndFullName = this.GetStringValueFromTempData(value: "TitleAndFullName"),
      };

      this.TempData.Keep();

      return model;
    }

    protected async Task<IActionResult> GetCountriesByCountryZoneId(string CountryZoneId)
    {
      var model = new CheckoutViewModel();

      if(string.IsNullOrEmpty(CountryZoneId))
      {
        CountryZoneId = "0";

        model.AvailableCountries.Add(new SelectListItem { Text = "Countries Will Show Here", Value = string.Empty });

        //var countryList = await this.CountryRepository.GetAllCountriesAsync();
        var countryList = await this.UnitOfWork.CountryRepository.GetAllCountriesAsync();

        foreach(var country in countryList)
        {
          model.AvailableCountries.Add(new SelectListItem
          {
            Text = country.CountryName,
            Value = country.Id.ToString(),
          });
        }
      }

      int.TryParse(CountryZoneId, out var id);

      //var countriesByCountryZoneIdList = await this.CountryRepository.GetAllCountriesByCountryZoneIdAsync(id);
      var countriesByCountryZoneIdList = await this.UnitOfWork.CountryRepository.GetAllCountriesByCountryZoneIdAsync(id);

      return new JsonResult((from country in countriesByCountryZoneIdList select new { id = country.Id, name = country.CountryName }).ToList());
    }
  }
}

