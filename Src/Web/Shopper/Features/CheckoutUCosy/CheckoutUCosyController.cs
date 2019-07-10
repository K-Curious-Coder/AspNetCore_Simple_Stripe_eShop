using System.Threading.Tasks;

using CoreControllers.Controllers;
using CoreControllers.ViewModels;

using CoreDomainFeature;
using CoreDomainFeature.ProductEntity;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.CheckoutUCosy
{
  public class CheckoutUCosyController : ShopController
  {
    public CheckoutUCosyController(IUnitOfWork unitOfWork, IOptionsFactory appSettings) : base(unitOfWork, appSettings) { }

    protected override Task<decimal> GetPostageZoneCost(int shippingRegionID) => this.UnitOfWork.ShippingCosyRepository.GetShippingCostFromDataSourceCosyAsync(shippingRegionID: shippingRegionID);

    [HttpGet("checkout-for-product-c")]
    public async Task<IActionResult> CheckoutForUCosy()
    {
      this.SetResourceCollection(controllerName: "Product C");

      return this.View(await this.OnGetCheckoutData(theSelectedProduct: ProductType.UCosy));
    }

    [HttpPost("checkout-for-product-c")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CheckoutForUCosy(CheckoutViewModel model)
    {
      this.SetResourceCollection(controllerName: "Product C");

      if(!this.ModelState.IsValid)
      {
        return this.View(await this.OnPostCheckoutData(model: model, theSelectedProduct: ProductType.UCosy));
      }

      await this.SetSessionPaymentData(model);
      await this.OnPostSetTempDataForCheckoutThanks(model: model);

      return this.RedirectToAction("BuyUCosy", "BuyUCosy");
    }

    [HttpGet("checkout-thanks-product-c")]
    public IActionResult CheckoutThanksCosy()
    {
      this.SetResourceCollection(controllerName: "Product C");

      return this.View(this.GetCheckoutThanksData());
    }

    [HttpGet("GetCountriesByCountryZoneIdCosy")]
    public Task<IActionResult> GetCountriesByCountryZoneIdCosy(string CountryZoneId) => this.GetCountriesByCountryZoneId(CountryZoneId);
  }
}