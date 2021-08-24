using Microsoft.AspNetCore.Mvc;
using WebApiWithAutofacDI.DTO;
using WebApiWithAutofacDI.Handlers;

namespace WebApiWithAutofacDI.Controllers
{
  [Route("RobotDancer")]
  public class RobotDancerController : Controller
  {
    private readonly IDanceHandler<RobotDancerDto> _danceHandler;

    public RobotDancerController(IDanceHandler<RobotDancerDto> danceHandler)
    {
      _danceHandler = danceHandler;
    }

    [HttpPost("MakeRobotDance")]
    public IActionResult MakeRobotDance([FromBody] RobotDancerDto dancerDto)
    {
      var result = _danceHandler.HandleDance(dancerDto);
      return Ok(result);
    }
  }
}