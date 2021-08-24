using WebAPIWithDotNetDI.DTO;

namespace WebAPIWithDotNetDI.Handlers
{
  public interface IDanceHandler<in TDancerDto> where TDancerDto : IDancerDto
  {
    string HandleDance(IDancerDto dancer);
  }
}