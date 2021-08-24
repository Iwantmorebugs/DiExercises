using System;

namespace WithoutDi
{
  public class RobotDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un robot bailarín");
    }

    string IDancer.DancerType => "robot";
  }
}