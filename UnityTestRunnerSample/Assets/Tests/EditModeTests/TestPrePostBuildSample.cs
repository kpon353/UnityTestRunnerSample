using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[PrebuildSetup(typeof(PrePostTestBuild))]
[PostBuildCleanup(typeof(PrePostTestBuild))]
public class TestPrePostBuildSample
{
  [Test]
  public void TestPrePostBuildSample01()
  {
    var value = 100f;
    Assert.That(Mathf.Approximately(100f, value));
  }

  [Test]
  public void TestPrePostBuildSample02()
  {
    var value = 100f * 1.2f;
    Assert.That(Mathf.Approximately(120f, value));
  }
}
