using BepInEx;
using Jotunn.Managers;
using System.Collections.Generic;
using System.Xml;

[BepInPlugin("buhikechi.SkeleNamesJP", "SkeleNamesJP", "1.0.0")]
[BepInDependency(Jotunn.Main.ModGuid)]
internal class SkeleNamesJP : BaseUnityPlugin
{
    // 元の英語名に対応する日本語訳をここに並べる
    private static readonly List<string> JapaneseNames = new List<string>
    {
        "TANAKA", "タナカ", "田中",
    };


    private void Awake() => PrefabManager.OnPrefabsRegistered += ApplyNames;

    private void ApplyNames()
    {
        var tameable = PrefabManager.Instance
            .GetPrefab("Skeleton_Friendly")?.GetComponent<Tameable>();
        if (tameable == null) { Jotunn.Logger.LogWarning("Tameable が取れない"); return; }

        // ここで元の英語リストがログに出る → 翻訳対象の一覧が手に入る
        Jotunn.Logger.LogInfo("元の名前: " + string.Join(", ", tameable.m_randomStartingName));

        tameable.m_randomStartingName = new List<string>(JapaneseNames);
    }
}