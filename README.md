# SkeleNamesJP

Valheim で召喚したスケルトン（`Skeleton_Friendly`）に付くランダムな名前を、
好きな日本語名に差し替える BepInEx プラグインです。[Jötunn](https://github.com/Valheim-Modding/Jotunn) を使っています。

初期状態では次の名前からランダムに付きます。

- TANAKA
- タナカ
- 田中

## 必要なもの

- Valheim
- [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)
- [Jötunn](https://thunderstore.io/c/valheim/p/ValheimModding/Jotunn/)（2.29.2 で確認）

## 導入

1. BepInEx と Jötunn を入れる
2. [Releases](https://github.com/buhikechi/valheim-skeleton-name-change-mod/releases/latest) から
   `SkeleNamesJP-Tanaka-v1.0.0.zip` をダウンロードして展開する
3. 中の `valheim_tanaka_mod.dll` を
   `Valheim/BepInEx/plugins/valheim_tanaka_mod/` に置く

自分でビルドする場合は、下の「ビルド」を見てください。

## 名前を変える

`valheim_tanaka_mod/Program.cs` の `JapaneseNames` を書き換えてビルドし直します。

```csharp
private static readonly List<string> JapaneseNames = new List<string>
{
    "TANAKA", "タナカ", "田中",
};
```

起動時、元の英語名の一覧が BepInEx のログに `元の名前: ...` として出るので、翻訳の参考にできます。

## ビルド

.NET SDK が必要です（ターゲットは .NET Framework 4.6.2）。

```bash
dotnet build -p:VALHEIM_INSTALL="C:\Program Files (x86)\Steam\steamapps\common\Valheim"
```

`VALHEIM_INSTALL` の既定値は `valheim_tanaka_mod.csproj` に書いてあります
（`D:\SteamLibrary\steamapps\common\Valheim`）。
そこに `BepInEx\plugins` があれば、ビルド後に DLL が自動でコピーされます。

## ライセンス

[MIT License](LICENSE)
