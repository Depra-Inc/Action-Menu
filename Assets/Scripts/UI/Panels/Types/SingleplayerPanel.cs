using UnityEngine;
using UnityEngine.SceneManagement;

namespace FD.UI.Panels
{
    internal class SingleplayerPanel : Panel
    {
        [SerializeField] private string _scene = "GameTest";

        // TEMP:

        public void StartNewGame()
        {
            SceneManager.LoadScene(_scene);
        }

        public void LoadGame()
        {
            SceneManager.LoadScene(_scene);
        }
    }
}