using System.Threading.Tasks;

using CoreControllers.ViewModels;

using CoreDomainFeature.LocationSharedData;
using CoreDomainFeature.ShippingSharedData;

using DependencyManagerFeature.OptionsEntity;


namespace CoreControllers.Controllers
{
  public abstract class ShopBaseController : AppBaseLiteController
  {
    protected CountryZoneValue countryZoneValue = new CountryZoneValue();
    protected ShippingRegionID shippingRegionID = new ShippingRegionID();

    protected ShopBaseController(IOptionsFactory appSettings) : base(appSettings) { }

    protected abstract Task<decimal> GetPostageZoneCost(int shippingRegionID);

    protected string GetStringValueFromTempData(string value) => !string.IsNullOrWhiteSpace(this.TempData[value].ToString()) ? this.TempData[value].ToString() : string.Empty;

    protected decimal GetCurrentShippingCost(decimal shippingCost, int productQuantity)
    {
      if(productQuantity > 5)
      {
        return (shippingCost * productQuantity) - (shippingCost * productQuantity * 0.10M);
      }
      else if(productQuantity > 10)
      {
        return (shippingCost * productQuantity) - (shippingCost * productQuantity * 0.20M);
      }

      return (shippingCost * productQuantity);
    }

    protected decimal GetIotal(decimal productPrice, int productQuantity, decimal shippingCost) => ((productPrice * productQuantity) + shippingCost);

    protected int GetProductQuantity(CheckoutViewModel model) => model.ProductQuantity;

    protected async Task<decimal> GetShippingCost(CheckoutViewModel model)
    {
      if((model.CountryZoneId == this.countryZoneValue.ZoneOne_One) || (model.CountryZoneId == this.countryZoneValue.ZoneOne_Two) || (model.CountryZoneId == this.countryZoneValue.ZoneOne_Three))
      {
        return await this.GetPostageZoneCost(shippingRegionID: this.shippingRegionID.Count_1);
      }
      else if(model.CountryZoneId == this.countryZoneValue.ZoneTwo)
      {
        return await this.GetPostageZoneCost(shippingRegionID: this.shippingRegionID.Count_2);
      }
      else if(model.CountryZoneId == this.countryZoneValue.ZoneThree)
      {
        return await this.GetPostageZoneCost(shippingRegionID: this.shippingRegionID.Count_3);
      }
      else if(model.CountryZoneId == this.countryZoneValue.ZoneFourEurope)
      {
        return await this.GetPostageZoneCost(shippingRegionID: this.shippingRegionID.Count_4);
      }
      else //if(model.CountryZoneId == this.countryZoneValue.ZoneFiveUnitedKingdom)
      {
        return await this.GetPostageZoneCost(shippingRegionID: this.shippingRegionID.Count_5);
      }

      //return CurrentPostageRate;
    }
  }
}

