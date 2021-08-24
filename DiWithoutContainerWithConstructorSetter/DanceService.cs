namespace DiWithoutContainerWithConstructorSetter
{
  public class DanceService : IDanceService
  {
    private IDancer _dancer;

    public DanceService(IDancer dancer)
    {
      _dancer = dancer;
    }

    public void ExecuteDance()
    {
      _dancer.Dance();
    }

    public void ChangeDancer(IDancer dancer)
    {
      _dancer = dancer;
    }
  }
}