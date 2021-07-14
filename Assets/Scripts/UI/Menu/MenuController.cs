using System;
using System.Collections.Generic;
using UnityEngine;

namespace FD.UI.Menues
{
    using Input;
    using Panels;

    [AddComponentMenu("FD/UI/Menu/Menu Controller")]
    [DisallowMultipleComponent]
    internal class MenuController : MonoBehaviour, IMenuController, IPanelController
    {
        [SerializeField] private Transform _panelsRoot = null;

        public Panel[] Panels => _panels.ToArray();

        public Action<Panel> PanelOpened { get; set; }
        public Action<Panel> PanelClosed { get; set; }

        private readonly Stack<Panel> _panelStack = new Stack<Panel>();
        private readonly List<Panel> _panels = new List<Panel>();

        private void Awake()
        {
            InputManager.Add(ActionMapNames.UI);
            InputManager.Controls.UI.Enable();

            if (_panelsRoot == null)
                _panelsRoot = transform;
            
            InitPanels();

            PanelOpened += OnPanelOpened;
            PanelClosed += OnPanelClosed;
        }

        private void OnDestroy()
        {
            InputManager.Remove(ActionMapNames.UI);
        }

        private void OnEnable()
        {
            InputManager.Controls.UI.CloseLast.performed += context => CloseLastPanel();
        }

        private void OnDisable()
        {
            InputManager.Controls.UI.CloseLast.performed -= context => CloseLastPanel();
        }

        public void OnPanelOpened(Panel panel)
        {
            _panelStack.Push(panel);
        }

        public void OnPanelClosed(Panel panel)
        {
            if (_panelStack.Count == 0)
                return;

            _panelStack.Pop();
        }

        public void OpenPanel(Panel panel)
        {
            if (panel == null)
                return;

            panel.Open();
        }
        
        public void CloseLastPanel()
        {
            if (_panelStack.Count == 0)
                return;

            var lastPanel = _panelStack.Peek();
            if (lastPanel is MainTabPanel)
                return;

            lastPanel.Close();

            var parentPanel = lastPanel.GetComponentInParent<Panel>();
            if (parentPanel)
                parentPanel.Close();
        }

        public void ClosePanel(Panel panel)
        {
            if (panel == null)
                return;

            panel.Close();

            var lastMenu = _panelStack.Peek();
            if (panel == lastMenu)
                _panelStack.Pop();
        }

        private void InitPanels()
        {
            _panels.Clear();

            if (InitPanelsFromRoot() == false)
            {
                Debug.Log($"[{nameof(MenuController)}]: Trying to load menu prefabs from resources.");

                InitPanelsFromResources();
            }
        }

        private void InitPanelsFromResources()
        {
            var panelPrefabs = Resources.LoadAll<Panel>("Prefabs/UI/Menues");

            if (panelPrefabs == null)
            {
                Debug.Log($"[{nameof(MenuController)}]: Menu prefabs not found!");
                return;
            }

            var result = new List<Panel>();
            foreach (var panelPrefab in panelPrefabs)
            {
                var panel = Instantiate(panelPrefab, _panelsRoot);
                panel.gameObject.SetActive(false);
                panel.name = panel.GetType().Name;
                panel.Init(this);

                _panels.Add(panel);
            }
        }

        private bool InitPanelsFromRoot()
        {
            var panelComponents = _panelsRoot.GetComponentsInChildren<Panel>(true);

            if (panelComponents == null || panelComponents.Length == 0)
            {
                Debug.Log($"[{nameof(MenuController)}]: No menu found in root!");
                return false;
            }

            foreach (Panel panel in panelComponents)
            {
                panel.gameObject.SetActive(false);
                panel.Init(this);

                _panels.Add(panel);
            }

            return true;
        }
    }
}
