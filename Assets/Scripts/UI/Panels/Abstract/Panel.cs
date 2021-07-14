using UnityEngine;

namespace FD.UI.Panels
{
    public abstract class Panel : MonoBehaviour, IElementUI
    {
        protected IPanelController Controller { get; private set; }

        public void Init(IPanelController controller)
        {
            Controller = controller;
            OnInitialized();
        }

        public void Open()
        {
            if (gameObject.activeSelf)
                return;

            gameObject.SetActive(true);

            Controller.PanelOpened?.Invoke(this);
        }

        public void Close()
        {
            if (gameObject.activeSelf == false)
                return;

            gameObject.SetActive(false);

            Controller.PanelClosed?.Invoke(this);
        }

        public void Toggle()
        {
            if (gameObject.activeSelf)
                Close();
            else
                Open();
        }
        
        protected virtual void OnInitialized()
        {
        }
    }
}
