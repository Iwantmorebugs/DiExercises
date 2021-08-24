using System;
using WithoutDiWithSmellCode.Dancers.Contracts;

namespace WithoutDiWithSmellCode.Dancers
{
  public class WolfDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un lobo bailarín");
    }

    string IDancer.DancerType => "wolf";
  }
}