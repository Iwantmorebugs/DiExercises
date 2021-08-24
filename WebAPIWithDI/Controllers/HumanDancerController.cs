using Microsoft.AspNetCore.Mvc;
using WebAPIWithDotNetDI.DTO;
using WebAPIWithDotNetDI.Handlers;

namespace WebAPIWithDotNetDI.Controllers
{
  [Route("HumanDancer")]
  public class HumanDancerController : Controller
  {
    private readonly IDanceHandler<HumanDancerDto> _danceHandler;

    public HumanDancerController(IDanceHandler<HumanDancerDto> danceHandler)
    {
      _danceHandler = danceHandler;
    }

    [HttpPost("MakeHumanDance")]
    public IActionResult MakeHumanDance([FromBody] HumanDancerDto dancerDto)
    {
      var result = _danceHandler.HandleDance(dancerDto);
      return Ok(result);
    }
  }
}