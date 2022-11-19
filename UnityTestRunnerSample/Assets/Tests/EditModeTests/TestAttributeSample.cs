using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestAttributeSample
{
  // A Test behaves as an ordinary method
  [Test]
  public void TestAttributeSampleSimplePasses()
  {
    var value = 1;
    Assert.That(1 == value);
  }

  [Test]
  public void TestAttributeSampleSimplePasses2()
  {
    var value = 5;
    Assert.That(10 > value);
  }

  /// <summary>
  /// 各テストが実行される前に毎回1度呼ばれる
  /// </summary>
  [SetUp]
  public void Setup()
  {
    Debug.Log("Setup");
  }

  /// <summary>
  /// 各テストが実行された後、毎回1度呼ばれる
  /// </summary>
  [TearDown]
  public void TearDown()
  {
    Debug.Log("TearDown");
  }

  /// <summary>
  /// 各テストが実行される前に毎回1度呼ばれる(コルーチン版)
  /// </summary>
  /// <returns></returns>
  [UnitySetUp]
  public IEnumerator UnitySetup()
  {
    Debug.Log("UnitySetup");
    yield break;
  }

  /// <summary>
  /// 各テストが実行された後、毎回1度呼ばれる(コルーチン版)
  /// </summary>
  /// <returns></returns>
  [UnityTearDown]
  public IEnumerator UnityTearDown()
  {
    Debug.Log("UnityTearDown");
    yield break;
  }

  /// <summary>
  /// 最初のテストが行われる前に1度だけ呼ばれる
  /// </summary>
  [OneTimeSetUp]
  public void OneTimeSetup()
  {
    Debug.Log("OneTimeSetup");
  }

  /// <summary>
  /// 最後のテストが実行された後に1度だけ呼ばれる
  /// </summary>
  [OneTimeTearDown]
  public void OneTimeTearDown()
  {
    Debug.Log("OneTimeTearDown");
  }
}
