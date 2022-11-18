using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestCodeSample
{
  [Test]
  public void TestCodeAddTax()
  {
    int fee = TestedCodeSample.AddTax(1000, false);
    Assert.That(1100, Is.EqualTo(fee));
  }
}
