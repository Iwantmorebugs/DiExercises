using System;

namespace DiWithoutContainerWithConstructorSetter
{
  public class RobotDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un robot bailarín");
    }
  }
}