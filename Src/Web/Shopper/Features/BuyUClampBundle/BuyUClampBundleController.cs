using System.Threading.Tasks;

using CoreControllers.Controllers;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.BuyUClampBundle
{
  public class BuyUClampBundleController : BuyController
  {
    public BuyUClampBundleController(IOptionsFactory appSettings) : base(appSettings) { }

    [HttpGet("buy-product-b")]
    public IActionResult BuyUClampBundle()
    {
      this.SetResourceCollection(controllerName: "Buy Product B");

      this.OnGetTempDataBuyProductGet();//??

      return this.View(this.GetBuyViewModel());
    }

    [HttpPost("buy-product-b")]
    public IActionResult BuyUClampBundle(string stripeEmail, string stripeToken)
    {
      this.SetResourceCollection(controllerName: "Buy Product B");

      if(!this.ModelState.IsValid)
      {
        return this.View();
      }

      this.Pay(stripeEmail, stripeToken);

      return this.RedirectToAction("CheckoutThanksBundle", "CheckoutUClampBundle");
    }
  }
}