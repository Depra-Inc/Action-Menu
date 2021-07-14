using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FD.UI.Menues.Background
{
    [AddComponentMenu("FD/UI/Menu/Background Controller")]
    [DisallowMultipleComponent]
    internal class BackgroundController : MonoBehaviour
    {
        [SerializeField] private BackgroundType defaultType = BackgroundType.Sprite;

        public IBackground ActiveBackground { get; private set; }

        public Action BackgroundChanged { get; set; }

        private IBackground[] _backgrounds = null;
        private int _lastIndex;

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
            var newIndex = IncreaseIndex(_lastIndex);
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
            if (index > _backgrounds.Length || _backgrounds[index] == null)
                return false;

            SetBackground(_backgrounds[index]);
            _lastIndex = index;

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
            _backgrounds = GetComponentsInChildren<IBackground>(true);
            if (_backgrounds == null || _backgrounds.Length == 0)
                return false;

            return true;
        }

        private bool InstantiateBackgroundsFromResources()
        {
            var prefabs = Resources.LoadAll("Prefabs/Backgrounds", typeof(IBackground));

            if (prefabs == null || prefabs.Length == 0)
                return false;

            _backgrounds = new IBackground[prefabs.Length];
            for (var i = 0; i < prefabs.Length; i++)
            {
                _backgrounds[i] = Instantiate(prefabs[i], transform) as IBackground;
                ((Object) _backgrounds[i]).name = _backgrounds[i].GetType().Name;
            }

            return true;
        }

        private IBackground GetByType(BackgroundType type)
        {
            IBackground result = null;

            for (var index = 0; index < _backgrounds.Length; index++)
            {
                if (_backgrounds[index].Type == type)
                {
                    result = _backgrounds[index];
                    _lastIndex = index;

                    break;
                }
            }

            return result;
        }

        private int IncreaseIndex(int index)
        {
            index++;

            if (index >= _backgrounds.Length)
                index = 0;

            return index;
        }

        private void OnBackgroundChanged()
        {
            Debug.Log($"[{nameof(BackgroundController)}]: Background changed");
        }
    }
}