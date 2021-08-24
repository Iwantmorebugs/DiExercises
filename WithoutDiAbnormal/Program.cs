using System;
using WithoutDiWithSmellCode.Dancers;
using WithoutDiWithSmellCode.Dancers.Contracts;
using WithoutDiWithSmellCode.DancerServices;
using WithoutDiWithSmellCode.DancerServices.Contracts;

namespace WithoutDiWithSmellCode
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IDancer dancer1 = new WolfDancer();
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
      else if (dancer1.DancerType == "wolf")
      {
        danceService = new WolfDanceService();
        danceService.ExecuteDance();
      }
      else if (dancer1.DancerType == "duck")
      {
        danceService = new DuckDanceService();
        danceService.ExecuteDance();
      }
      else if (dancer1.DancerType == "cat")
      {
        danceService = new CatDanceService();
        danceService.ExecuteDance();
      }

      Console.ReadKey();
    }
  }
}