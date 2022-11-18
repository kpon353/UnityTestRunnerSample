using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestedCodeSample
{
  /// <summary>
  /// 料金に税金を上乗せします
  /// </summary>
  /// <param name="Fee"></param>
  /// <param name="isFood"></param>
  /// <returns></returns>
  public static int AddTax(int Fee, bool isFood)
  {
    if (isFood)
    {
      return MultiplyAndRoundup(Fee, 1.08f);
    }
    return MultiplyAndRoundup(Fee, 1.1f);
  }

  /// <summary>
  /// 2数を掛け算し、小数点以下を切り上げ整数にします
  /// </summary>
  /// <param name="number"></param>
  /// <param name="magnification"></param>
  /// <returns></returns>
  public static int MultiplyAndRoundup(int number, float magnification)
  {
    return Mathf.CeilToInt(number * magnification);
  }
}
