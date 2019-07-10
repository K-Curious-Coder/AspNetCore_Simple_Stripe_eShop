using System.Threading.Tasks;

using CoreControllers.Controllers;
using CoreControllers.ViewModels;

using CoreDomainFeature;
using CoreDomainFeature.ProductEntity;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.CheckoutUClampSolo
{
  public class CheckoutUClampSoloController : ShopController
  {
    public CheckoutUClampSoloController(IUnitOfWork unitOfWork, IOptionsFactory appSettings) : base(unitOfWork, appSettings) { }

    protected override Task<decimal> GetPostageZoneCost(int shippingRegionID) => this.UnitOfWork.ShippingSoloRepository.GetShippingCostFromDataSourceSoloAsync(shippingRegionID: shippingRegionID);

    [HttpGet("checkout-for-product-a")]
    public async Task<IActionResult> CheckoutForUClampSolo()
    {
      this.SetResourceCollection(controllerName: "Product A");

      return this.View(await this.OnGetCheckoutData(theSelectedProduct: ProductType.UClampSolo));
    }

    [HttpPost("checkout-for-product-a")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CheckoutForUClampSolo(CheckoutViewModel model)
    {
      this.SetResourceCollection(controllerName: "Product A");

      if(!this.ModelState.IsValid)
      {
        return this.View(await this.OnPostCheckoutData(model: model, theSelectedProduct: ProductType.UClampSolo));
      }

      await this.SetSessionPaymentData(model);
      await this.OnPostSetTempDataForCheckoutThanks(model: model);

      return this.RedirectToAction("BuyUClampSolo", "BuyUClampSolo");
    }

    [HttpGet("checkout-thanks-product-a")]
    public IActionResult CheckoutThanksSolo()
    {
      this.SetResourceCollection(controllerName: "Product A");

      return this.View(this.GetCheckoutThanksData());
    }

    [HttpGet("GetCountriesByCountryZoneIdSolo")]
    public Task<IActionResult> GetCountriesByCountryZoneIdSolo(string CountryZoneId) => this.GetCountriesByCountryZoneId(CountryZoneId);
  }
}