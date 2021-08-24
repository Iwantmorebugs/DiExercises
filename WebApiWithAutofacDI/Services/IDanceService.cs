using WebApiWithAutofacDI.DTO;

namespace WebApiWithAutofacDI.Services
{
  public interface IDanceService
  {
    public string ExecuteDance(IDancerDto dancer);
  }
}