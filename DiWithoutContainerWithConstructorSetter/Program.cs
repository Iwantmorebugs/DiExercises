using System;

namespace DiWithoutContainerWithConstructorSetter
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IDancer humanDancer = new HumantDancer();
      IDancer robotDancer = new RobotDancer();

      IDanceService danceService = new DanceService(humanDancer);

      danceService.ExecuteDance();

      danceService.ChangeDancer(robotDancer);

      danceService.ExecuteDance();

      Console.ReadKey();
    }
  }
}