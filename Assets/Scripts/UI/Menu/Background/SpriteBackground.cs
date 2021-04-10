using UnityEngine;

namespace FD.UI.Menues.Background
{
    internal class SpriteBackground : MonoBehaviour, IBackground
    {
        [SerializeField] bool disableLight = true;

        public BackgroundType Type => BackgroundType.Sprite;
        public bool IsActive { get; private set; }

        private Light[] lightSources;

        private void Awake()
        {
            if (disableLight)
                lightSources = FindObjectsOfType<Light>();

            Disable();
        }

        public void Enable()
        {
            Toggle(true);
        }

        public void Disable()
        {
            Toggle(false);
        }

        private void Toggle(bool flag)
        {
            for (var i = 0; i < transform.childCount; i++)
            {
                var childObject = transform.GetChild(i);
                childObject.gameObject.SetActive(flag);
            }

            IsActive = flag;
            gameObject.SetActive(flag);

            if (disableLight == false)
                return;

            for (var i = 0; i < lightSources.Length; i++)
                lightSources[i].gameObject.SetActive(true);
        }
    }
}
