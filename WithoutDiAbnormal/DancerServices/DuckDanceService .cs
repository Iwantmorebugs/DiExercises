using WithoutDiWithSmellCode.Dancers;
using WithoutDiWithSmellCode.Dancers.Contracts;
using WithoutDiWithSmellCode.DancerServices.Contracts;

namespace WithoutDiWithSmellCode.DancerServices
{
  public class DuckDanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public DuckDanceService()
    {
      _dancer = new DucktDancer();
    }


    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}