using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPIWithDotNetDI.DTO;
using WebAPIWithDotNetDI.Handlers;
using WebAPIWithDotNetDI.Services;

namespace WebAPIWithDotNetDI
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      RegisterDanceServices(services);
      services.AddControllers();
    }

    private static void RegisterDanceServices(IServiceCollection services)
    {
      services.AddSingleton<IDanceService, DanceService>();
      services.AddScoped<IDanceHandler<HumanDancerDto>, HumanDanceHandler>();
      services.AddScoped<IDanceHandler<RobotDancerDto>, RobotDanceHandler>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
  }
}