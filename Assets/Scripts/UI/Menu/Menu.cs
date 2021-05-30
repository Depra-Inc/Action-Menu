using UnityEngine;

namespace FD.UI.Menues
{
    internal abstract class Menu : MonoBehaviour, IElementUI
    {
        public abstract MenuType Type { get; }

        protected IMenuController Controller { get; private set; }

        public virtual void Init(IMenuController controller)
        {
            Controller = controller;
        }

        public void Open()
        {
            if (gameObject.activeSelf)
                return;

            gameObject.SetActive(true);

            Controller.MenuOpened?.Invoke(this);
        }

        public void Close()
        {
            if (gameObject.activeSelf == false)
                return;

            gameObject.SetActive(false);

            Controller.MenuClosed?.Invoke(this);
        }

        public void Toggle()
        {
            if (gameObject.activeSelf)
                Close();
            else
                Open();
        }
    }
}
