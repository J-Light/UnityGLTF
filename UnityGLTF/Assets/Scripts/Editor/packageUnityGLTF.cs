#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class packageUnityGLTF : EditorWindow
{
    [MenuItem("GLTF/Make Package")]
    public static void MakePackage()
    {
        string[] files = new string[]
            {
                "Assets/UnityGLTF",
            };
        AssetDatabase.ExportPackage(
            files,
            "UnityGLTF.unitypackage",
            ExportPackageOptions.Recurse);
    }
}
#endif
