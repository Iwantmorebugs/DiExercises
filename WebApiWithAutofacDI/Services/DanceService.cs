using WebApiWithAutofacDI.DTO;

namespace WebApiWithAutofacDI.Services
{
  public class DanceService : IDanceService
  {
    public string ExecuteDance(IDancerDto dancer)
    {
      return $"I am dancing this: {dancer.KindOfDance}";
    }
  }
}