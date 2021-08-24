using WebApiWithAutofacDI.DTO;

namespace WebApiWithAutofacDI.Handlers
{
  public interface IDanceHandler<in TDancerDto> where TDancerDto : IDancerDto
  {
    string HandleDance(IDancerDto dancer);
  }
}