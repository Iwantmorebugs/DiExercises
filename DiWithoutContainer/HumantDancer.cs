using System;

namespace DiWithoutContainer
{
  public class HumantDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un humano bailarín");
    }
  }
}