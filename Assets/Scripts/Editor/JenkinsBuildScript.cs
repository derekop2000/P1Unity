using UnityEditor;

using UnityEngine;

public class JenkinsBuildScript
{
    [MenuItem("Build/Build Project")]
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/MainScene.unity" };
        string path = System.Environment.GetEnvironmentVariable("WORKSPACE") + "/Builds/Windows/P1.exe";

        BuildPipeline.BuildPlayer(scenes, path, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
