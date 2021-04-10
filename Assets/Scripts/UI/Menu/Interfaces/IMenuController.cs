using System;

namespace FD.UI.Menues
{
    internal interface IMenuController
    {
        Menu[] Menues { get; }

        Action OnGameStarted { get; set; }
        Action OnGameEnded { get; set; }

        void OpenMenu(MenuType type);
        void ToggleMenu(MenuType type);
        void CloseMenu(MenuType type);
        void CloseLastMenu();
    }
}
