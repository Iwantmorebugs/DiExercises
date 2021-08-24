using WithoutDiWithSmellCode.Dancers;
using WithoutDiWithSmellCode.Dancers.Contracts;
using WithoutDiWithSmellCode.DancerServices.Contracts;

namespace WithoutDiWithSmellCode.DancerServices
{
  public class WolfDanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public WolfDanceService()
    {
      _dancer = new WolfDancer();
    }


    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}