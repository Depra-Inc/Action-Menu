using FD.Core;
using UnityEngine;
using UnityEngine.UI;

namespace FD.UI.Menues
{
    internal class ExitMenu : Menu
    {
        [SerializeField] Button confirmButton = null;
        [SerializeField] Button cancelButton = null;

        public override MenuType Type => MenuType.Exit;

        private void Awake()
        {
            confirmButton.onClick.AddListener(ConfirmExit);
            cancelButton.onClick.AddListener(Close);
        }

        public void ConfirmExit()
        {
            Close();
            Game.QuitGame();
        }
    }
}
