using System;
using UnityEngine;

namespace FD.UI.Menues.Background
{
    [AddComponentMenu("FD/UI/Menu/Background Controller")]
    [DisallowMultipleComponent]
    internal class BackgroundController : MonoBehaviour
    {
        [SerializeField] BackgroundType defaultType = BackgroundType.Sprite;

        public IBackground ActiveBackground { get; private set; }

        public Action BackgroundChanged { get; set; }

        private IBackground[] backgrounds = null;
        private int lastIndex;

        private void Awake()
        {
            Init();
            ChangeTypeTo(defaultType);
        }

        private void OnEnable()
        {
            BackgroundChanged += OnBackgroundChanged;
        }

        private void OnDisable()
        {
            BackgroundChanged -= OnBackgroundChanged;
        }

        public void SetNext()
        {
            var newIndex = IncreaseIndex(lastIndex);
            ChangeTo(newIndex);
        }

        public bool ChangeTypeTo(BackgroundType newType)
        {
            var background = GetByType(newType);
            if (background == null)
                return false;

            SetBackground(background);

            return true;
        }

        private bool ChangeTo(int index)
        {
            if (index > backgrounds.Length || backgrounds[index] == null)
                return false;

            SetBackground(backgrounds[index]);
            lastIndex = index;

            return true;
        }

        private void SetBackground(IBackground background)
        {
            if (ActiveBackground != null)
                ActiveBackground.Disable();

            ActiveBackground = background;
            ActiveBackground.Enable();

            BackgroundChanged?.Invoke();
        }

        private void Init()
        {
            if (TryGetBackgroundsInChildrens())
                return;

            for (var i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);
                Destroy(child.gameObject);
            }

            if (InstantiateBackgroundsFromResources() == false)
            {
                Debug.Log($"[{nameof(BackgroundController)}]: No backgrounds available!");
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
                (backgrounds[i] as UnityEngine.Object).name = backgrounds[i].GetType().Name;
            }

            return true;
        }

        private IBackground GetByType(BackgroundType type)
        {
            IBackground result = null;

            for (var index = 0; index < backgrounds.Length; index++)
            {
                if (backgrounds[index].Type == type)
                {
                    result = backgrounds[index];
                    lastIndex = index;

                    break;
                }
            }

            return result;
        }

        private int IncreaseIndex(int index)
        {
            index++;

            if (index >= backgrounds.Length)
                index = 0;

            return index;
        }

        private void OnBackgroundChanged()
        {
            Debug.Log($"[{nameof(BackgroundController)}]: Background changed");
        }
    }
}
