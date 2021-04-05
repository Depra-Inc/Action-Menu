using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FD.UI.Menu
{
    public interface IMenuController
    {
        GameObject[] Menues { get; set; }

        Action OnGameStarted { get; set; }
        Action OnGameEnded { get; set; }

        Action OnExitButtonPressed { get; set; }
        Action OnExitConfirmed { get; set; }
        Action OnExitCanceled { get; set; }

        void ToggleStartGamePanel();
        void ToggleOptionsPanel();
        void ToggleExitPanel();

        void ShowStartPanel();
        void ShowOptionsPanel();
        void ShowExitPanel();

    }
}
