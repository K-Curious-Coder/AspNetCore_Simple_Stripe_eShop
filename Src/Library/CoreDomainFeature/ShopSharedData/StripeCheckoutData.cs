namespace CoreDomainFeature.ShopSharedData
{
  public class StripeCheckoutData : ViewDataBase
  {
    public decimal TotalCostFeedback { get; set; }

    public string StripeKeyPublishable { get; set; }
  }
}
