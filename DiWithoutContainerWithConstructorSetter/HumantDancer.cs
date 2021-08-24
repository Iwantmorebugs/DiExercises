using System;

namespace DiWithoutContainerWithConstructorSetter
{
  public class HumantDancer : IDancer
  {
    public void Dance()
    {
      Console.WriteLine("Soy un humano bailarín");
    }
  }
}