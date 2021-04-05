using System;
using UnityEngine;

namespace FD.UI.Menu.Background
{
    public class BackgroundController : MonoBehaviour
    {
        [SerializeField] BackgroundType defaultType = BackgroundType.Sprite;

        public IBackground ActiveBackground { get; private set; }

        public Action OnBackgroundChanged { get; set; }

        private IBackground[] backgrounds = null;

        private void Awake()
        {
            Init();

            ChangeTypeTo(defaultType);
        }

        private void OnEnable()
        {
            OnBackgroundChanged += () => Debug.Log($"[{nameof(BackgroundController)}]: Background changed");
        }

        private void OnDisable()
        {
            OnBackgroundChanged -= () => Debug.Log($"[{nameof(BackgroundController)}]: Background changed");
        }

        public bool ChangeTypeTo(BackgroundType newType)
        {
            var background = GetByType(newType);

            if (background == null)
                return false;

            if (ActiveBackground != null)
                ActiveBackground.Disable();

            background.Enable();

            OnBackgroundChanged?.Invoke();

            return true;
        }

        private void Init()
        {
            if (TryGetBackgroundsInChildrens() == false)
            {
                for (var i = 0; i < transform.childCount; i++)
                {
                    var child = transform.GetChild(i);
                    Destroy(child.gameObject);
                }

                if (InstantiateBackgroundsFromResources() == false)
                {
                    Debug.Log($"[{nameof(BackgroundController)}]: No backgrounds available!");
                    return;
                }
            }
        }

        private bool TryGetBackgroundsInChildrens()
        {
            backgrounds = GetComponentsInChildren<IBackground>(true);

            if (backgrounds == null || backgrounds.Length == 0)
                return false;

            return true;
        }

        private bool InstantiateBackgroundsFromResources()
        {
            var prefabs = Resources.LoadAll("Prefabs/Backgrounds", typeof(IBackground));

            if (prefabs == null || prefabs.Length == 0)
                return false;

            backgrounds = new IBackground[prefabs.Length];
            for (var i = 0; i < prefabs.Length; i++)
            {
                backgrounds[i] = Instantiate(prefabs[i], transform) as IBackground;
            }

            return true;
        }

        private IBackground GetByType(BackgroundType type)
        {
            IBackground result = null;

            for (var i = 0; i < backgrounds.Length; i++)
            {
                if (backgrounds[i].Type == type)
                {
                    result = backgrounds[i];
                    break;
                }
            }

            return result;
        }

    }
}
