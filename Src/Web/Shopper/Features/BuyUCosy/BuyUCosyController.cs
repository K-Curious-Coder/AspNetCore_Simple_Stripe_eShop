using System.Threading.Tasks;

using CoreControllers.Controllers;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.BuyUCosy
{
  public class BuyUCosyController : BuyController
  {
    public BuyUCosyController(IOptionsFactory appSettings) : base(appSettings) { }

    [HttpGet("buy-product-c")]
    public IActionResult BuyUCosy()
    {
      this.SetResourceCollection(controllerName: "Buy Product C");

      this.OnGetTempDataBuyProductGet();//??

      return this.View(this.GetBuyViewModel());
    }

    [HttpPost("buy-product-c")]
    public IActionResult BuyUCosy(string stripeEmail, string stripeToken)
    {
      this.SetResourceCollection(controllerName: "Buy Product C");

      if(!this.ModelState.IsValid)
      {
        return this.View();
      }

      this.Pay(stripeEmail, stripeToken);

      return this.RedirectToAction("CheckoutThanksCosy", "CheckoutUCosy");
    }
  }
}