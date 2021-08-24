using System;
using WithoutDiWithSmellCode.Dancers.Contracts;

namespace WithoutDiWithSmellCode.Dancers
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