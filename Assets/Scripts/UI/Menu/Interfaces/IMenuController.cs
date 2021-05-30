using System;

namespace FD.UI.Menues
{
    internal interface IMenuController
    {
        Menu[] Menues { get; }

        Action GameStarted { get; set; }
        Action GameEnded { get; set; }
        Action<Menu> MenuOpened { get; set; }
        Action<Menu> MenuClosed { get; set; }
    }
}
