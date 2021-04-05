using UnityEngine;

namespace FD.UI.Menu.Background
{
    public class SpriteBackground : MonoBehaviour, IBackground
    {
        [SerializeField] BackgroundType type = default;

        public BackgroundType Type => type;
        public bool IsActive { get; private set; }

        private void Awake()
        {
            Disable();
        }

        public void Enable() => Toggle(true);

        public void Disable() => Toggle(false);

        private void Toggle(bool flag)
        {
            for (var i = 0; i < transform.childCount; i++)
            {
                var childObject = transform.GetChild(i);
                childObject.gameObject.SetActive(flag);
            }

            gameObject.SetActive(flag);
        }
    }
}
