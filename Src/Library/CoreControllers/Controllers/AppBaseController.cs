using DependencyManagerFeature.OptionsEntity;

namespace CoreControllers.Controllers
{
  public abstract class AppBaseController : AppBaseLiteController
  {
    public AppBaseController(IOptionsFactory appSettings) : base(appSettings)
    {
    }
  }
}
