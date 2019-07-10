using Microsoft.Extensions.Options;

namespace DependencyManagerFeature.OptionsEntity
{
  public class OptionsFactory : IOptionsFactory
  {
    private readonly AppSettings appSettings;

    public OptionsFactory(IOptionsMonitor<AppSettings> options) => this.appSettings = options.CurrentValue;

    public AppSettings GetAppSettings() => this.appSettings;
  }
}
