using Autofac;
using WebApiWithAutofacDI.DTO;
using WebApiWithAutofacDI.Handlers;

namespace WebApiWithAutofacDI.DI
{
  public class HandlersModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<HumanDanceHandler>()
        .As<IDanceHandler<HumanDancerDto>>()
        .InstancePerLifetimeScope();

      builder.RegisterType<RobotDanceHandler>()
        .As<IDanceHandler<RobotDancerDto>>()
        .InstancePerLifetimeScope();
    }
  }
}