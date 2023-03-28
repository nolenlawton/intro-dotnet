using System;
using System.Linq;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        return (flower1 + flower2) % 2 == 1;
    }
}

// why is this needed to work...???

// using System;
// using System.Linq;

public class StringInArray
{
  public static bool Check(object[] a, object x)
  {
    return a.Contains(x);
  }
}


public class SumOfPositives
{
  public static int PositiveSum(int[] arr)
  {
    int answer = 0;
      
    foreach (int number in arr) {
      if (number > 0) {
        answer += number;
      }
    }
    return answer;
  }
}
