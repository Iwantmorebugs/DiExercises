using WebAPIWithDotNetDI.DTO;
using WebAPIWithDotNetDI.Services;

namespace WebAPIWithDotNetDI.Handlers
{
  public class RobotDanceHandler : IDanceHandler<RobotDancerDto>
  {
    private readonly IDanceService _danceService;

    public RobotDanceHandler(IDanceService danceService)
    {
      _danceService = danceService;
    }

    public string HandleDance(IDancerDto dancer)
    {
      var danceResult = _danceService.ExecuteDance(dancer);
      return $"I'm a Robot and {danceResult}";
    }
  }
}