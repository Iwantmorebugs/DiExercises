using System;

namespace WithoutDi
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