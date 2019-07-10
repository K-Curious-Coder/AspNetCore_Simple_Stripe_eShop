using CoreFeature.BaseDataModels;

using DependencyManagerFeature.OptionsEntity;

namespace CoreControllers.Controllers
{
  public abstract class BuyBaseController : AppBaseController
  {
    public BuyBaseController(IOptionsFactory appSettings) : base(appSettings) { }

    protected void OnGetTempDataBuyProductGet()
    {
      this.TempData.Keep();

      this.TempData["UserFeedbackThanks_ProductName_TempData_Buy_Get"] = this.TempData["ProductName"];
      this.TempData["UserFeedbackThanks_BuyPageProductPrice_TempData_Buy_Get"] = this.TempData["UserFeedbackThanksProductPrice"];
      this.TempData["UserFeedbackThanks_TotalCost_TempData_Buy_Get"] = this.TempData["UserFeedbackThanksTotalCost"];
      this.TempData["UserFeedbackThanks_BuyPageShippingCost_TempData_Buy_Get"] = this.TempData["UserFeedbackThanksCurrentPostageRate"];
      this.TempData["UserFeedbackThanks_ProductQuantity_TempData_Buy_Get"] = this.TempData["UserFeedbackThanksProductQuantity"];
      this.TempData["UserFeedbackThanks_TitleAndFullName_TempData_Buy_Get"] = this.TempData["TitleAndFullName"];

      this.TempData.Keep();
    }

    protected int GetIntValueFromTempData(string value)
    {
      if(this.TempData.ContainsKey(value))
      {
        int.TryParse(this.TempData[value].ToString(), out var outValue);

        return outValue;
      }
      else
      {
        return 0;
      }
    }

    protected decimal GetDecimalValueFromTempData(string value)
    {
      if(this.TempData.ContainsKey(value))
      {
        decimal.TryParse(this.TempData[value].ToString(), out var outValue);

        return decimal.Parse(outValue.ToString("0.00"));
      }
      else
      {
        return MoneyValue.InvalidDecimalValue;
      }
    }
  }
}
