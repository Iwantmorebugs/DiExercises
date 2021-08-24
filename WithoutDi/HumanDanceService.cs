namespace WithoutDi
{
  public class HumanDanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public HumanDanceService()
    {
      _dancer = new HumantDancer();
    }


    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}