//using System.Threading.Tasks;
//using AppDAL.CountryEntity;
//using AppDAL.CountryZoneEntity;
//using AppDAL.ProductEntity;
//using AppDAL.ShippingBundleEntity;
//using AppDAL.ShippingCosyEntity;
//using AppDAL.ShippingSoloEntity;
//using CoreControllers.Controllers;
//using CoreControllers.ViewModels;

//using CoreFeature.Helpers;

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Options;

//namespace Shopper.Features.CheckoutUClampSolo
//{
//  public class CheckoutUClampSoloController : ShopController
//  {
//    public CheckoutUClampSoloController
//    (
//     ICountryZoneRepository countryZoneRepository,
//     ICountryRepository countryRepository,
//     IProductRepository productRepository,
//     IShippingBundleRepository shippingBundleRepository,
//     IShippingCosyRepository shippingCosyRepository,
//     IShippingSoloRepository shippingSoloRepository,
//     IOptions<AppSettings> appSettings
//    )
//    :
//    base
//    (
//     countryZoneRepository,
//     countryRepository,
//     productRepository,
//     shippingBundleRepository,
//     shippingCosyRepository,
//     shippingSoloRepository,
//     appSettings
//    )
//    { }

//    protected override Task<decimal> GetPostageZoneCost(int shippingRegionID) => this.ShippingSoloRepository.GetShippingCostFromDataSourceSoloAsync(shippingRegionID: shippingRegionID);

//    [HttpGet("checkout-for-product-a")]
//    public async Task<IActionResult> CheckoutForUClampSolo()
//    {
//      this.SetResourceCollection(controllerName: "Product A");

//      return this.View(await this.OnGetCheckoutData(theSelectedProduct: ProductType.UClampSolo));
//    }

//    [HttpPost("checkout-for-product-a")]
//    [ValidateAntiForgeryToken]
//    public async Task<IActionResult> CheckoutForUClampSolo(CheckoutViewModel model)
//    {
//      this.SetResourceCollection(controllerName: "Product A");

//      if(!this.ModelState.IsValid)
//      {
//        return this.View(await this.OnPostCheckoutData(model: model, theSelectedProduct: ProductType.UClampSolo));
//      }

//      await this.SetSessionPaymentData(model);
//      await this.OnPostSetTempDataForCheckoutThanks(model: model);

//      return this.RedirectToAction("BuyUClampSolo", "BuyUClampSolo");
//    }

//    [HttpGet("checkout-thanks-product-a")]
//    public IActionResult CheckoutThanksSolo()
//    {
//      this.SetResourceCollection(controllerName: "Product A");

//      return this.View(this.GetCheckoutThanksData());
//    }

//    [HttpGet("GetCountriesByCountryZoneIdSolo")]
//    public Task<IActionResult> GetCountriesByCountryZoneIdSolo(string CountryZoneId) => this.GetCountriesByCountryZoneId(CountryZoneId);
//  }
//}