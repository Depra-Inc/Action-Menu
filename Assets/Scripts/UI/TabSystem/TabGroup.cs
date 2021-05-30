using System.Linq;
using UnityEngine;

namespace FD.UI.TabSystem
{
    using Input;
    using Menues;

    public class TabGroup : MonoBehaviour
    {
        [SerializeField] TabButton[] tabButtons = null;
        [SerializeField] Menu[] menuesToSwap = null;

        [SerializeField] Color tabIdleColor = Color.white;
        [SerializeField] Color tabActiveColor = Color.red;

        [SerializeField] bool isUsingKeyboard = false;
        [SerializeField] bool isCanBeInactive = false;

        public Color TabIdleColor => tabIdleColor;
        public Color TabActiveColor => tabActiveColor;

        private TabButton activeTab;
        private TabButton lastSelectedTab;

        private MenuController menuController;

        private void Awake()
        {
            menuController = FindObjectOfType<MenuController>();
            menuController.MenuClosed += OnMenuClosed;

            for (var i = 0; i < tabButtons.Length; i++)
            {
                tabButtons[i].Init(this, i);
            }
        }

        private void Start()
        {
            if (isCanBeInactive == false)
                OnTabSelected(tabButtons[0]);
        }

        private void OnEnable()
        {
            if (isUsingKeyboard == false)
                return;

            if (isCanBeInactive == false && activeTab == null)
            {
                if (lastSelectedTab)
                    OnTabSelected(lastSelectedTab);
                else
                    ShowNextTab();
            }

            InputManager.Controls.UI.PreviousTab.performed += context => ShowPreviousTab();
            InputManager.Controls.UI.NextTab.performed += context => ShowNextTab();
        }

        private void OnDisable()
        {
            if (isUsingKeyboard == false)
                return;

            InputManager.Controls.UI.PreviousTab.performed -= context => ShowPreviousTab();
            InputManager.Controls.UI.NextTab.performed -= context => ShowNextTab();
        }

        public void OnTabSelected(TabButton button)
        {
            if (activeTab)
                activeTab.Deselect();

            if (button == null)
                return;

            int index = button.Index;

            if (activeTab == button && isCanBeInactive)
            {
                activeTab = null;
                button.Deselect();

                menuesToSwap[index].Close();
            }
            else
            {
                activeTab = button;
                activeTab.Select();
                lastSelectedTab = activeTab;

                for (int i = 0; i < menuesToSwap.Length; i++)
                {
                    if (i == index)
                        menuesToSwap[i].Open();
                    else
                        menuesToSwap[i].Close();
                }
            }

            ResetTabs();
        }

        public void ShowNextTab()
        {
            if (tabButtons.Length < 0)
                return;

            int newIndex;

            if (activeTab == null)
                newIndex = 0;
            else
                newIndex = activeTab.Index + 1;

            if (newIndex >= tabButtons.Length)
                newIndex = 0;

            OnTabSelected(tabButtons[newIndex]);
        }

        public void ShowPreviousTab()
        {
            if (tabButtons.Length < 0)
                return;

            int newIndex = activeTab.Index - 1;

            if (newIndex < 0)
                newIndex = tabButtons.Length - 1;

            OnTabSelected(tabButtons[newIndex]);
        }

        public void ResetTabs()
        {
            foreach (var button in tabButtons.Where(button => activeTab == null || button != activeTab))
            {
                button.Deselect();
            }
        }

        private void OnMenuClosed(Menu menu)
        {
            if (activeTab == null)
                return;

            var closedMenu = menuesToSwap[activeTab.Index];

            if (menu != closedMenu)
                return;

            activeTab.Deselect();
            activeTab = null;
        }
    }
}