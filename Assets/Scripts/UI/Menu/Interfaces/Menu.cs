using UnityEngine;

namespace FD.UI.Menues
{
    internal abstract class Menu : MonoBehaviour, IElementUI
    {
        public abstract MenuType Type { get; }

        protected IMenuController controller;

        public virtual void Init(IMenuController controller)
        {
            this.controller = controller;
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Toggle()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
