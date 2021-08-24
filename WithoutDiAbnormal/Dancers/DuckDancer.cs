using System;
using WithoutDiWithSmellCode.Dancers.Contracts;

namespace WithoutDiWithSmellCode.Dancers
{
  public class DucktDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un pato bailarín");
    }

    string IDancer.DancerType => "duck";
  }
}