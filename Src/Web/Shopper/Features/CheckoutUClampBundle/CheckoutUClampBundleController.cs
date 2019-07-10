using System.Threading.Tasks;

using CoreControllers.Controllers;
using CoreControllers.ViewModels;

using CoreDomainFeature;
using CoreDomainFeature.ProductEntity;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.CheckoutUClampBundle
{
  public class CheckoutUClampBundleController : ShopController
  {
    public CheckoutUClampBundleController(IUnitOfWork unitOfWork, IOptionsFactory appSettings) : base(unitOfWork, appSettings) { }

    protected override Task<decimal> GetPostageZoneCost(int shippingRegionID) => this.UnitOfWork.ShippingBundleRepository.GetShippingCostFromDataSourceBundleAsync(shippingRegionID: shippingRegionID);

    [HttpGet("checkout-for-product-b")]
    public async Task<IActionResult> CheckoutForUClampBundle()
    {
      this.SetResourceCollection(controllerName: "Product B");

      return this.View(await this.OnGetCheckoutData(theSelectedProduct: ProductType.UClampBundle));
    }

    [HttpPost("checkout-for-product-b")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CheckoutForUClampBundle(CheckoutViewModel model)
    {
      this.SetResourceCollection(controllerName: "Product B");

      if(!this.ModelState.IsValid)
      {
        return this.View(await this.OnPostCheckoutData(model: model, theSelectedProduct: ProductType.UClampBundle));//?
      }

      await this.SetSessionPaymentData(model);
      await this.OnPostSetTempDataForCheckoutThanks(model: model);

      return this.RedirectToAction("BuyUClampBundle", "BuyUClampBundle");
    }

    [HttpGet("checkout-thanks-product-b")]
    public IActionResult CheckoutThanksBundle()
    {
      this.SetResourceCollection(controllerName: "Product B");

      return this.View(this.GetCheckoutThanksData());
    }

    [HttpGet("GetCountriesByCountryZoneIdBundle")]
    public Task<IActionResult> GetCountriesByCountryZoneIdBundle(string CountryZoneId) => this.GetCountriesByCountryZoneId(CountryZoneId);
  }
}