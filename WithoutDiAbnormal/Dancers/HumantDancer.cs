using System;
using WithoutDiWithSmellCode.Dancers.Contracts;

namespace WithoutDiWithSmellCode.Dancers
{
  public class HumantDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un humano bailarín");
    }

    string IDancer.DancerType => "human";
  }
}