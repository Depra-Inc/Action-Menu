using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace FD.Core
{
    public static class Game
    {
        public static bool IsHeadless => SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null;

        public static bool IsGameQuitting { get; private set; }

        public static void QuitGame()
        {
            IsGameQuitting = true;

            //if (NetworkManager.singleton != null)
            //    NetworkManager.singleton.StopHost();

#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
        }

        public static string GetGameExecutePath()
        {
#if UNITY_EDITOR
            return Directory.GetParent(Application.dataPath).FullName + "/Game";
#else
			return Directory.GetParent(Application.dataPath).FullName;
#endif
        }

        public static string GetGameConfigPath()
        {
            return null;
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void Init()
        {
            Application.quitting += () => IsGameQuitting = true;
        }
    }
}