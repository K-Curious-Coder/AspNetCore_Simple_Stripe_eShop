using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CoreExtensionFeature
{
  public static class CookieService
  {
    public static void ConfigureSession(this IServiceCollection services)
    {
      services.AddDistributedMemoryCache();

      services.AddSession();
    }

    public static void ConfigureCookiePolicy(this IServiceCollection services)
    {
      services.Configure<CookiePolicyOptions>(options =>
      {
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      services.Configure<CookieTempDataProviderOptions>(options =>
      {
        options.Cookie.IsEssential = true;
      });
    }
  }
}
