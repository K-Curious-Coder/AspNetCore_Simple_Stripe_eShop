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

//namespace Shopper.Features.CheckoutUCosy
//{
//  public class CheckoutUCosyController : ShopController
//  {
//    public CheckoutUCosyController
//    (
//      ICountryZoneRepository countryZoneRepository,
//      ICountryRepository countryRepository,

//      IProductRepository productRepository,

//      IShippingBundleRepository shippingBundleRepository,
//      IShippingCosyRepository shippingCosyRepository,
//      IShippingSoloRepository shippingSoloRepository,

//      IOptions<AppSettings> appSettings
//    )
//    :
//    base
//    (
//      countryZoneRepository,
//      countryRepository,

//      productRepository,

//      shippingBundleRepository,
//      shippingCosyRepository,
//      shippingSoloRepository,

//      appSettings
//    )
//    { }

//    protected override Task<decimal> GetPostageZoneCost(int shippingRegionID) => this.ShippingCosyRepository.GetShippingCostFromDataSourceCosyAsync(shippingRegionID: shippingRegionID);

//    [HttpGet("checkout-for-product-c")]
//    public async Task<IActionResult> CheckoutForUCosy()
//    {
//      this.SetResourceCollection(controllerName: "Product C");

//      return this.View(await this.OnGetCheckoutData(theSelectedProduct: ProductType.UCosy));
//    }

//    [HttpPost("checkout-for-product-c")]
//    [ValidateAntiForgeryToken]
//    public async Task<IActionResult> CheckoutForUCosy(CheckoutViewModel model)
//    {
//      this.SetResourceCollection(controllerName: "Product C");

//      if(!this.ModelState.IsValid)
//      {
//        return this.View(await this.OnPostCheckoutData(model: model, theSelectedProduct: ProductType.UCosy));
//      }

//      await this.SetSessionPaymentData(model);
//      await this.OnPostSetTempDataForCheckoutThanks(model: model);

//      return this.RedirectToAction("BuyUCosy", "BuyUCosy");
//    }

//    [HttpGet("checkout-thanks-product-c")]
//    public IActionResult CheckoutThanksCosy()
//    {
//      this.SetResourceCollection(controllerName: "Product C");

//      return this.View(this.GetCheckoutThanksData());
//    }

//    [HttpGet("GetCountriesByCountryZoneIdCosy")]
//    public Task<IActionResult> GetCountriesByCountryZoneIdCosy(string CountryZoneId) => this.GetCountriesByCountryZoneId(CountryZoneId);
//  }
//}