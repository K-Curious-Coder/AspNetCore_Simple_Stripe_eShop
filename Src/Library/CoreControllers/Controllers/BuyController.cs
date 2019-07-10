using CoreDomainFeature.ShopSharedData;

using DependencyManagerFeature.OptionsEntity;

using Stripe;

namespace CoreControllers.Controllers
{
  public abstract class BuyController : BuyBaseController
  {
    public BuyController(IOptionsFactory appSettings) : base(appSettings) { }

    protected StripeCheckoutData GetBuyViewModel()
    {
      this.TempData.Keep();

      decimal.TryParse(this.TempData["UserFeedbackBuyPageProductPrice"].ToString(), out var productPrice);
      int.TryParse(this.TempData["UserFeedbackBuyPageProductQuantity"].ToString(), out var productQuantity);
      decimal.TryParse(this.TempData["UserFeedbackBuyPageShippingCost"].ToString(), out var shippingCost);
      int.TryParse(this.TempData["TotalCostGet"].ToString(), out var totalCost);
      decimal.TryParse(this.TempData["UserFeedbackBuyPageTotalCost"].ToString(), out var totalCostFeedback);

      var model = new StripeCheckoutData()
      {
        ProductName = this.TempData["ProductName"].ToString(),
        ProductDescription = this.TempData["ProductDescription"].ToString(),

        ProductPrice = productPrice,
        ProductQuantity = productQuantity,
        ShippingCost = shippingCost,
        TotalCost = totalCost,
        TotalCostFeedback = totalCostFeedback,
        StripeKeyPublishable = this.appSettings.KeyPublishable
      };

      return model;
    }

    protected void Pay(string stripeEmail, string stripeToken)
    {
      int.TryParse(this.TempData["TotalCostPost"].ToString(), out var amount);

      var chargeCreateOptions = new ChargeCreateOptions();

      chargeCreateOptions.Amount = amount;
      chargeCreateOptions.Description = this.TempData["ProductDescription"].ToString();

      chargeCreateOptions.Currency = this.appSettings.Currency;
      chargeCreateOptions.SourceId = stripeToken;
      chargeCreateOptions.ReceiptEmail = stripeEmail;

      var service = new ChargeService();
      var charge = service.Create(chargeCreateOptions);
    }

  }
}

