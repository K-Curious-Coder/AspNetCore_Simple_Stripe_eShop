using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;

namespace CoreExtensionFeature
{
  public static class RazorViewService
  {
    public static void ConfigureFeatures(this IServiceCollection services)
    {
      services.Configure<RazorViewEngineOptions>(o =>
      {
        o.ViewLocationFormats.Add("~/Features/{1}/{0}" + RazorViewEngine.ViewExtension);
        o.ViewLocationFormats.Add("~/Features/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
        o.ViewLocationFormats.Add("~/Features/Shared/{0}" + RazorViewEngine.ViewExtension);
        //
        //o.AreaViewLocationFormats.Clear();
        o.AreaViewLocationFormats.Add("~/Areas/{2}/Features/{1}/{0}" + RazorViewEngine.ViewExtension);
        o.AreaViewLocationFormats.Add("~/Areas/{2}/Features/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
        o.AreaViewLocationFormats.Add("~/Areas/{2}/Features/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
        o.AreaViewLocationFormats.Add("~/Areas/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
      });
    }
  }
}
