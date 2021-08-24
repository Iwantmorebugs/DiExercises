using System;
using WithoutDiWithSmellCode.Dancers.Contracts;

namespace WithoutDiWithSmellCode.Dancers
{
  public class CatDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un gato bailarín");
    }

    string IDancer.DancerType => "cat";
  }
}