using WithoutDiWithSmellCode.Dancers;
using WithoutDiWithSmellCode.Dancers.Contracts;
using WithoutDiWithSmellCode.DancerServices.Contracts;

//jouj dial hwayej
namespace WithoutDiWithSmellCode.DancerServices
{
  public class CatDanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public CatDanceService()
    {
      _dancer = new CatDancer();
    }


    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}