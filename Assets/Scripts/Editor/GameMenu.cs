using System.IO;
using UnityEditor;
using UnityEngine;

namespace FD.Editor
{
    public class GameMenu : EditorWindow
    {
        [MenuItem("Game/Clear Player Prefs")]
        public static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }

        [MenuItem("Game/Take Screenshot")]
        public static void TakeScreenshot()
        {
            var path = "Screenshots";

            Directory.CreateDirectory(path);

            int i = 0;
            while (File.Exists($"{path}/{i}.png"))
            {
                i++;
            }

            ScreenCapture.CaptureScreenshot($"{path}/{i}.png");
        }
    }
}