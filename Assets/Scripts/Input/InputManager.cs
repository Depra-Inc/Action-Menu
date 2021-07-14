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
                if (_controls != null)
                    return _controls;

                return _controls = new Controls();
            }
        }
        private static Controls _controls;

        private static readonly IDictionary<string, int> MapStates = new Dictionary<string, int>();

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
            _controls.Dispose();
        }

        public static void Add(string mapName)
        {
            MapStates.TryGetValue(mapName, out int value);
            MapStates[mapName] = value + 1;

            UpdateMapState(mapName);
        }

        public static void Remove(string mapName)
        {
            MapStates.TryGetValue(mapName, out int value);
            MapStates[mapName] = Mathf.Max(value - 1, 0);

            UpdateMapState(mapName);
        }

        private static void UpdateMapState(string mapName)
        {
            int value = MapStates[mapName];

            if (value > 0)
            {
                Controls.asset.FindActionMap(mapName).Disable();
                return;
            }

            Controls.asset.FindActionMap(mapName).Enable();
        }
    }
}
