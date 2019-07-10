namespace RandomNumberFeature.NumberListRules
{
  public class FirstNumberSetGenerator
  {
    RandomNumberGenerator random = new RandomNumberGenerator();

    public int[] FirstSetOfNumbers { get; set; }

    public FirstNumberSetGenerator() => this.FirstSetOfNumbers = new int[5];


    #region SetUp First Number
    private int val1Check;
    private void ProcessVal1(int index)
    {
      this.val1Check = this.random.GetCurrentNumberForFirstSetOfNumbers();
      this.FirstSetOfNumbers[index] = this.val1Check;
    }
    private void SetFirstNumber(int i) => this.ProcessVal1(i);
    #endregion


    #region SetUp Second Number
    private int val2Check;
    private void ProcessVal2(int index)
    {
      this.val2Check = this.random.GetCurrentNumberForFirstSetOfNumbers();
      this.FirstSetOfNumbers[index] = this.val2Check;
    }
    private void SetSecondNumber(int i)
    {
      var isRepeat = false;

      do
      {
        this.ProcessVal2(i);

        for(var val2Count = 0; val2Count < 1; val2Count++)
        {
          if(this.val2Check == this.FirstSetOfNumbers[val2Count])
          {
            isRepeat = true;
          }
        }

      } while(isRepeat);
    }
    #endregion


    #region SetUp Third Number
    private int val3Check;
    private void ProcessVal3(int index)
    {
      this.val3Check = this.random.GetCurrentNumberForFirstSetOfNumbers();
      this.FirstSetOfNumbers[index] = this.val3Check;
    }
    private void SetThirdNumber(int i)
    {
      var isRepeat = false;

      do
      {
        this.ProcessVal3(i);

        for(var val3Count = 0; val3Count < 2; val3Count++)
        {
          if(this.val3Check == this.FirstSetOfNumbers[val3Count])
          {
            isRepeat = true;
          }
        }

      } while(isRepeat);
    }
    #endregion


    #region SetUp Fourth Number
    private int val4Check;
    private void ProcessVal4(int index)
    {
      this.val4Check = this.random.GetCurrentNumberForFirstSetOfNumbers();
      this.FirstSetOfNumbers[index] = this.val4Check;
    }
    private void SetFourthNumber(int i)
    {
      var isRepeat = false;

      do
      {
        this.ProcessVal4(i);

        for(var val4Count = 0; val4Count < 3; val4Count++)
        {
          if(this.val4Check == this.FirstSetOfNumbers[val4Count])
          {
            isRepeat = true;
          }
        }

      } while(isRepeat);
    }
    #endregion


    #region SetUp Fifth Number
    private int val5Check;
    private void ProcessVal5(int index)
    {
      this.val5Check = this.random.GetCurrentNumberForFirstSetOfNumbers();
      this.FirstSetOfNumbers[index] = this.val5Check;
    }
    private void SetFifthNumber(int i)
    {
      var isRepeat = false;

      do
      {
        this.ProcessVal5(i);

        for(var val5Count = 0; val5Count < 4; val5Count++)
        {
          if(this.val5Check == this.FirstSetOfNumbers[val5Count])
          {
            isRepeat = true;
          }
        }

      } while(isRepeat);
    }
    #endregion


    public void GenerateNumbers()
    {
      for(var i = 0; i < this.FirstSetOfNumbers.Length; i++)
      {
        if(i == 0)
        {
          this.SetFirstNumber(i);
        }
        else if(i == 1)
        {
          this.SetSecondNumber(i);
        }
        else if(i == 2)
        {
          this.SetThirdNumber(i);
        }
        else if(i == 3)
        {
          this.SetFourthNumber(i);
        }
        else if(i == 4)
        {
          this.SetFifthNumber(i);
        }
      }
    }
  }
}
