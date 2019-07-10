using System;

namespace RandomNumberFeature
{
  public class RandomNumberGenerator
  {
    private Random random = new Random();

    // Generates a number between 1 and 50
    public int GetCurrentNumberForFirstSetOfNumbers() => this.random.Next(1, 51);

    // Generates a number between 1 and 11
    public int GetCurrentNumberForSecondSetOfNumbers() => this.random.Next(1, 12);
  }
}
