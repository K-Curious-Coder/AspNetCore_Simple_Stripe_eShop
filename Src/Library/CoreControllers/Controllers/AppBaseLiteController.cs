using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace CoreControllers.Controllers
{
  public abstract class AppBaseLiteController : Controller
  {
    protected readonly AppSettings appSettings;

    public AppBaseLiteController(IOptionsFactory options) => this.appSettings = options.GetAppSettings();

    public void SetResourceCollection(string controllerName)
    {
      this.ViewData["Title"] = $"{this.appSettings.Title} - {controllerName}";

      this.ViewData["Description"] = this.appSettings.Description;

      this.ViewData["PersonalDetails"] = this.appSettings.PersonalDetails;
      this.ViewData["ContactDetails"] = this.appSettings.ContactDetails;

      this.ViewData["ContactMessage"] = this.appSettings.ContactMessage;
      this.ViewData["GetInTouch"] = this.appSettings.GetInTouch;
      this.ViewData["GetInTouchSubHeading"] = this.appSettings.GetInTouchSubHeading;
      this.ViewData["GetInTouchMessage"] = this.appSettings.GetInTouchMessage;


      this.ViewData["YourMessageIsRequired"] = this.appSettings.YourMessageIsRequired;

      this.ViewData["Products"] = this.appSettings.Products;

      this.ViewData["ProductA"] = this.appSettings.ProductA;
      this.ViewData["ProductACheckout"] = this.appSettings.ProductACheckout;

      this.ViewData["ProductB"] = this.appSettings.ProductB;
      this.ViewData["ProductBCheckout"] = this.appSettings.ProductBCheckout;

      this.ViewData["ProductC"] = this.appSettings.ProductC;
      this.ViewData["ProductCCheckout"] = this.appSettings.ProductCCheckout;

      this.ViewData["Home"] = this.appSettings.Home;
      this.ViewData["About"] = this.appSettings.About;
      this.ViewData["Contact"] = this.appSettings.Contact;
    }
  }
}
