namespace WithoutDiWithSmellCode.Dancers.Contracts
{
  public interface IDancer
  {
    public string DancerType { get; }
    void Dance();
  }
}