using System.IO;

using CoreExtensionFeature;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

using PersistenceFeature;

using Stripe;

namespace Shopper.Helpers
{
  public static class ServiceManager
  {
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
      var appSettingsSection = configuration.GetSection("AppSettings");
      services.Configure<AppSettings>(appSettingsSection);

      services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), appSettingsSection.Get<AppSettings>().StaticFilesDirectory)));

      services.ConfigureFeatures();

      services.ConfigureSession();
      services.ConfigureCookiePolicy();

      services.ConfigureDbContext(configuration);
      services.ConfigureIdentity();

      services.ConfigureRepositories();

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddSessionStateTempDataProvider();
    }

    public static void UseConfigurations(this IApplicationBuilder app, IHostingEnvironment env, IConfiguration configuration)
    {
      if(env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");

        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseSession();

      StripeConfiguration.SetApiKey(configuration.GetSection("AppSettings").Get<AppSettings>().KeySecret);

      app.UseMvcWithDefaultRoute();
      app.UseCookiePolicy();
    }
  }
}
