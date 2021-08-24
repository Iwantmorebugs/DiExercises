using Autofac;
using WebApiWithAutofacDI.Services;

namespace WebApiWithAutofacDI.DI
{
  public class ServicesModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<DanceService>()
        .As<IDanceService>()
        .SingleInstance();
    }
  }
}