using WebAPIWithDotNetDI.DTO;
using WebAPIWithDotNetDI.Services;

namespace WebAPIWithDotNetDI.Handlers
{
  public class HumanDanceHandler : IDanceHandler<HumanDancerDto>
  {
    private readonly IDanceService _danceService;

    public HumanDanceHandler(IDanceService danceService)
    {
      _danceService = danceService;
    }

    public string HandleDance(IDancerDto dancer)
    {
      var danceResult = _danceService.ExecuteDance(dancer);
      return $"I'm a human and {danceResult}";
    }
  }
}