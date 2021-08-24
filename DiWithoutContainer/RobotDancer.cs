using System;

namespace DiWithoutContainer
{
  public class RobotDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un robot bailarín");
    }
  }
}