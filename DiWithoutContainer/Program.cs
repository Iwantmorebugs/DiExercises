using System;

namespace DiWithoutContainer
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IDancer humanDancer = new HumantDancer();
      IDancer robotDancer = new RobotDancer();

      IDanceService danceService = new DanceService(humanDancer);

      danceService.ExecuteDance();

      IDanceService danceService2 = new DanceService(robotDancer);

      danceService2.ExecuteDance();

      Console.ReadKey();
    }
  }
}