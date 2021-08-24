namespace WithoutDi
{
  public class RobotDanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public RobotDanceService()
    {
      _dancer = new RobotDancer();
    }


    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}