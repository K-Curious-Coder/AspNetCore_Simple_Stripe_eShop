using System.Runtime.InteropServices;

using CoreDomainFeature;
using CoreDomainFeature.CountryEntity;
using CoreDomainFeature.CountryZoneEntity;
using CoreDomainFeature.ProductEntity;
using CoreDomainFeature.ShippingBundleEntity;
using CoreDomainFeature.ShippingCosyEntity;
using CoreDomainFeature.ShippingSoloEntity;

using DependencyManagerFeature.OptionsEntity;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PersistenceFeature.CountryEntity;
using PersistenceFeature.CountryZoneEntity;
using PersistenceFeature.ProductEntity;
using PersistenceFeature.ShippingBundleEntity;
using PersistenceFeature.ShippingCosyEntity;
using PersistenceFeature.ShippingSoloEntity;


namespace PersistenceFeature
{
  public static class RepositoryService
  {
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration config)
    {
      services.AddDbContext<ApplicationDbContext>(options =>
      {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
          options.UseSqlite("Data Source=App.db");
        }
        else
        {
          options.UseSqlite("Data Source=App.db");
        }
      });
    }

    public static void ConfigureIdentity(this IServiceCollection services) => services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ApplicationDbContext>();

    public static void ConfigureRepositories(this IServiceCollection services)
    {
      services.AddScoped<IOptionsFactory, OptionsFactory>();

      services.AddScoped<ICountryZoneRepository, CountryZoneRepository>();
      services.AddScoped<ICountryRepository, CountryRepository>();
      services.AddScoped<IProductRepository, ProductRepository>();

      services.AddScoped<IShippingBundleRepository, ShippingBundleRepository>();
      services.AddScoped<IShippingCosyRepository, ShippingCosyRepository>();
      services.AddScoped<IShippingSoloRepository, ShippingSoloRepository>();

      services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
  }
}
