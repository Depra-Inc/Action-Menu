using System.Linq;
using UnityEngine;

namespace FD.UI.TabSystem
{
    using Input;
    using Panels;

    public class TabGroup : MonoBehaviour
    {
        [SerializeField] private TabButton[] _tabButtons = null;
        [SerializeField] private Panel[] _panelsToSwap = null;

        [SerializeField] private Color _tabIdleColor = Color.white;
        [SerializeField] private Color _tabActiveColor = Color.red;

        [SerializeField] private bool _isUsingKeyboard;
        [SerializeField] private bool _isCanBeInactive;

        public Color TabIdleColor => _tabIdleColor;
        public Color TabActiveColor => _tabActiveColor;

        private TabButton _activeTab;
        private TabButton _lastSelectedTab;

        private IPanelController _panelController;

        private void Awake()
        {
            _panelController = FindObjectsOfType<MonoBehaviour>().OfType<IPanelController>().First();
            _panelController.PanelClosed += OnPanelClosed;

            for (var i = 0; i < _tabButtons.Length; i++)
            {
                _tabButtons[i].Init(this, i);
            }
        }

        private void Start()
        {
            if (_isCanBeInactive == false)
                OnTabSelected(_tabButtons[0]);
        }

        private void OnEnable()
        {
            if (_isUsingKeyboard == false)
                return;
            
            if (_isCanBeInactive == false && _activeTab == null)
            {
                if (_lastSelectedTab)
                    OnTabSelected(_lastSelectedTab);
                else
                    ShowNextTab();
            }

            InputManager.Controls.UI.PreviousTab.performed += context => ShowPreviousTab();
            InputManager.Controls.UI.NextTab.performed += context => ShowNextTab();
        }

        private void OnDisable()
        {
            if (_isUsingKeyboard == false)
                return;

            InputManager.Controls.UI.PreviousTab.performed -= context => ShowPreviousTab();
            InputManager.Controls.UI.NextTab.performed -= context => ShowNextTab();
        }

        public void OnTabSelected(TabButton button)
        {
            if (_activeTab)
                _activeTab.Deselect();

            if (button == null)
                return;

            var index = button.Index;

            if (_activeTab == button && _isCanBeInactive)
            {
                _activeTab = null;
                button.Deselect();

                _panelsToSwap[index].Close();
            }
            else
            {
                _activeTab = button;
                _activeTab.Select();
                _lastSelectedTab = _activeTab;

                for (var i = 0; i < _panelsToSwap.Length; i++)
                {
                    if (i == index)
                        _panelsToSwap[i].Open();
                    else
                        _panelsToSwap[i].Close();
                }
            }

            ResetTabs();
        }

        public void ShowNextTab()
        {
            if (_tabButtons.Length < 1)
                return;

            int newIndex;

            if (_activeTab == null)
                newIndex = 0;
            else
                newIndex = _activeTab.Index + 1;

            if (newIndex >= _tabButtons.Length)
                newIndex = 0;

            OnTabSelected(_tabButtons[newIndex]);
        }

        public void ShowPreviousTab()
        {
            if (_tabButtons.Length < 1)
                return;

            var newIndex = _activeTab.Index - 1;

            if (newIndex < 0)
                newIndex = _tabButtons.Length - 1;

            OnTabSelected(_tabButtons[newIndex]);
        }

        public void Init(TabButton[] buttons, Panel[] panels)
        {
            _tabButtons = buttons;
            _panelsToSwap = panels;
        }
        
        private void ResetTabs()
        {
            foreach (TabButton button in _tabButtons.Where(button => _activeTab == null || button != _activeTab))
            {
                button.Deselect();
            }
        }

        private void OnPanelClosed(Panel panel)
        {
            if (_activeTab == null)
                return;

            var closedPanel = _panelsToSwap[_activeTab.Index];

            if (panel != closedPanel)
                return;

            _activeTab.Deselect();
            _activeTab = null;
        }
    }
}