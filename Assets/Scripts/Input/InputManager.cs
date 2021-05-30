using System.Collections.Generic;
using UnityEngine;

namespace FD.Input
{
    public class InputManager : MonoBehaviour
    {
        public static Controls Controls
        {
            get
            {
                if (controls != null)
                    return controls;

                return controls = new Controls();
            }
        }
        private static Controls controls;

        private static readonly IDictionary<string, int> mapStates = new Dictionary<string, int>();

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void OnEnable()
        {
            Controls.Enable();
        }

        public void OnDisable()
        {
            Controls.Disable();
        }

        public void OnDestroy()
        {
            controls.Dispose();
        }

        public static void Add(string mapName)
        {
            mapStates.TryGetValue(mapName, out int value);
            mapStates[mapName] = value + 1;

            UpdateMapState(mapName);
        }

        public static void Remove(string mapName)
        {
            mapStates.TryGetValue(mapName, out int value);
            mapStates[mapName] = Mathf.Max(value - 1, 0);

            UpdateMapState(mapName);
        }

        private static void UpdateMapState(string mapName)
        {
            int value = mapStates[mapName];

            if (value > 0)
            {
                Controls.asset.FindActionMap(mapName).Disable();
                return;
            }

            Controls.asset.FindActionMap(mapName).Enable();
        }
    }
}
