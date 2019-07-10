using CoreControllers.Controllers;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Mvc;

namespace Shopper.Features.About
{
  public class AboutController : AppBaseLiteController
  {
    public AboutController(IOptionsFactory options) : base(options){}

    [HttpGet("about")]
    public IActionResult Index()
    {
      this.SetResourceCollection(controllerName: "About");

      return this.View();
    }
  }
}