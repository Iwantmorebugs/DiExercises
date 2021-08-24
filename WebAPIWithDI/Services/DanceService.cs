using WebAPIWithDotNetDI.DTO;

namespace WebAPIWithDotNetDI.Services
{
  public class DanceService : IDanceService
  {
    public string ExecuteDance(IDancerDto dancer)
    {
      return $"I am dancing this: {dancer.KindOfDance}";
    }
  }
}