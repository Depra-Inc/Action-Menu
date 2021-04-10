using UnityEngine;

namespace FD.UI.Menues.Background
{
    internal class PrototypeBackground : MonoBehaviour, IBackground
    {
        public BackgroundType Type => BackgroundType.Prototype;

        public bool IsActive { get; private set; }

        private void Awake()
        {
            Disable();
        }

        public void Enable()
        {
            gameObject.SetActive(true);

            IsActive = true;
        }

        public void Disable()
        {
            IsActive = false;

            gameObject.SetActive(false);
        }
    }
}
