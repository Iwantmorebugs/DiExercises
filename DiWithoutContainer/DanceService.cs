namespace DiWithoutContainer
{
  public class DanceService : IDanceService
  {
    private readonly IDancer _dancer;

    public DanceService(IDancer dancer)
    {
      _dancer = dancer;
    }

    public void ExecuteDance()
    {
      _dancer.Dance();
    }
  }
}