using CoreControllers.Controllers;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.Home
{
  public class HomeController : AppBaseLiteController
  {
    public HomeController(IOptionsFactory appSettings) : base(appSettings) { }

    [HttpGet("")]
    public IActionResult Index()
    {
      this.SetResourceCollection(controllerName: "Home");

      return this.View();
    }
  }
}
