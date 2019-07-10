namespace CoreDomainFeature.ShopSharedData
{
  public class PaymentData
  {
    //public bool IsDebug { get; set; }
    public string IsDebug { get; set; }
    public string IsDebugThanks { get; set; }


    public string ProductName { get; set; }
    public string ProductDescription { get; set; }

    public decimal ProductPrice { get; set; }

    public decimal ShippingCost { get; set; }

    public int ProductQuantity { get; set; }

    public int TotalCost { get; set; }

    public decimal UserFeedbackTotalCost { get; set; }

    public decimal UserFeedbackShippingCost { get; set; }

    public decimal UserFeedbackCurrentPostageRate { get; set; }

    public decimal UserFeedbackTotalCostThanks { get; set; }

    public string UserFeedbackProductName { get; set; }


    public string CustomerEmail { get; set; }

    //TitleAndFullName
    public string TitleAndFullName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailSubject { get; set; }

    public string EmailBody { get; set; }

    public string SelectedTitle { get; set; }

    public string SelectedColour { get; set; }

    //Thanks Section
    public string UserFeedbackThanksProductName { get; set; }

    public decimal UserFeedbackThanksProductPrice { get; set; }

    public decimal UserFeedbackThanksProductQuantity { get; set; }

    public decimal UserFeedbackThanksShippingCost { get; set; }

    public decimal UserFeedbackThanksCurrentPostageRate { get; set; }

    public decimal UserFeedbackThanksTotalCost { get; set; }
  }
}
