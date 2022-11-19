using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Reflection;

public class TestCodeSample
{
  [Test]
  public void TestCodeAddTax()
  {
    int fee = TestedCodeSample.AddTax(1000, false);
    Assert.That(1100, Is.EqualTo(fee));
  }

  [Test]
  public void TestCodeMultiplyAndRoundup()
  {
    var myClass = typeof(TestedCodeSample);
    Assert.That(myClass, !Is.Null);

    var myMethod = myClass.GetMethod("MultiplyAndRoundup", BindingFlags.NonPublic | BindingFlags.Static);
    Assert.That(myMethod, !Is.Null);

    var value = (int)myMethod.Invoke(this, new object[] { 1000, 1.1f });
    Assert.That(1100, Is.EqualTo(value));
  }
}
