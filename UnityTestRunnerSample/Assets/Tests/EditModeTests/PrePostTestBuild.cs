using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// 他のテストからテスト開始前と終了後にやりたい事がある場合に使われる
/// 使われ方は以下の感じ(1つのテスト単位でもつけられるし、クラス自体にもつけられる)
/// [PrebuildSetup(typeof(PrePostTestBuild))]
/// [PostBuildCleanup(typeof(PrePostTestBuild))]
/// </summary>
public class PrePostTestBuild : IPrebuildSetup, IPostBuildCleanup
{
  /// <summary>
  /// 最初のテストを行う前に呼ばれる処理
  /// テスト用のリソース確保とかに使われる
  /// </summary>
  void IPrebuildSetup.Setup()
  {
    Debug.Log("PreBuild.Setup");
  }

  /// <summary>
  /// テスト終了後に呼ばれる処理
  /// テスト用に確保していたリソースを解放するとかで使われる
  /// </summary>
  void IPostBuildCleanup.Cleanup()
  {
    Debug.Log("PostBuild.Setup");
  }
}
