using WebAPIWithDotNetDI.DTO;

namespace WebAPIWithDotNetDI.Services
{
  public interface IDanceService
  {
    public string ExecuteDance(IDancerDto dancer);
  }
}