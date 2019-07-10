
using CoreControllers.Controllers;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.BuyUClampSolo
{
  public class BuyUClampSoloController : BuyController
  {
    public BuyUClampSoloController(IOptionsFactory appSettings) : base(appSettings) { }

    [HttpGet("buy-product-a")]
    public IActionResult BuyUClampSolo()
    {
      this.SetResourceCollection(controllerName: "Buy Product A");

      this.OnGetTempDataBuyProductGet();//??

      return this.View(this.GetBuyViewModel());
    }

    [HttpPost("buy-product-a")]
    public IActionResult BuyUClampSolo(string stripeEmail, string stripeToken)
    {
      this.SetResourceCollection(controllerName: "Buy Product A");

      if(!this.ModelState.IsValid)
      {
        return this.View();
      }

      this.Pay(stripeEmail, stripeToken);

      return this.RedirectToAction("CheckoutThanksSolo", "CheckoutUClampSolo");
    }
  }
}