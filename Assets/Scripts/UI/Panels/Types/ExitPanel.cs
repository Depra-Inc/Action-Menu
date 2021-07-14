using FD.Core;
using UnityEngine;
using UnityEngine.UI;

namespace FD.UI.Panels
{
    internal class ExitPanel : Panel
    {
        [SerializeField] private Button _confirmButton = null;
        [SerializeField] private Button _cancelButton = null;
        
        private void Awake()
        {
            _confirmButton.onClick.AddListener(ConfirmExit);
            _cancelButton.onClick.AddListener(Close);
        }

        public void ConfirmExit()
        {
            Close();
            Game.QuitGame();
        }
    }
}
