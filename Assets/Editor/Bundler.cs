using UnityEditor;
using UnityEngine;
using System;

public class CreateAssetBundles
{
    [UnityEditor.MenuItem ("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles ()
    {
        BuildPipeline.BuildAssetBundles ("RoR2_AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
 