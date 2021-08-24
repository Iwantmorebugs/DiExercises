using System;

namespace WithoutDi
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IDancer dancer1 = new HumantDancer();
      IDanceService danceService;

      if (dancer1.DancerType == "human")
      {
        danceService = new HumanDanceService();
        danceService.ExecuteDance();
      }
      else if (dancer1.DancerType == "robot")
      {
        danceService = new RobotDanceService();
        danceService.ExecuteDance();
      }

      IDancer dancer2 = new RobotDancer();

      if (dancer2.DancerType == "human")
      {
        danceService = new HumanDanceService();
        danceService.ExecuteDance();
      }
      else if (dancer2.DancerType == "robot")
      {
        danceService = new RobotDanceService();
        danceService.ExecuteDance();
      }

      Console.ReadKey();
    }
  }
}