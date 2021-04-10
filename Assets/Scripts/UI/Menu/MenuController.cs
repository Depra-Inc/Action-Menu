using FD.Input;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FD.UI.Menues
{
    internal class MenuController : MonoBehaviour, IMenuController
    {
        [SerializeField] Transform menuesRoot = null;

        public Menu[] Menues { get; private set; }

        public Action OnGameStarted { get; set; }
        public Action OnGameEnded { get; set; }

        private Stack<Menu> menuStack = new Stack<Menu>();

        private Dictionary<MenuType, Menu> menues = new Dictionary<MenuType, Menu>();

        private void Awake()
        {
            InputManager.Add(ActionMapNames.UI);

            InitMenues();

            OpenMenu(MenuType.Main);
        }

        private void OnEnable()
        {
            InputManager.Controls.UI.CloseLast.performed += context => CloseLastMenu();
        }

        private void OnDisable()
        {
            InputManager.Controls.UI.CloseLast.performed -= context => CloseLastMenu();
        }

        public void OpenMenu(MenuType type)
        {
            var menu = GetMenuByType(type);
            if (menu == null)
                return;

            menu.Open();

            menuStack.Push(menu);
        }

        public void ToggleMenu(MenuType type)
        {
            var menu = GetMenuByType(type);
            if (menu == null)
                return;

            menu.Toggle();

            if (menu.isActiveAndEnabled)
                menuStack.Push(menu);
            else
                menuStack.Pop();
        }

        public void CloseLastMenu()
        {
            var lastMenu = menuStack.Pop();

            if (lastMenu.Type == MenuType.Main)
            {
                OpenMenu(MenuType.Exit);
                return;
            }

            lastMenu.Close();
        }

        public void CloseMenu(MenuType type)
        {
            var menu = GetMenuByType(type);
            if (menu == null)
                return;

            menu.Close();

            var lastMenu = menuStack.Peek();
            if (menu == lastMenu)
                menuStack.Pop();
        }

        private Menu GetMenuByType(MenuType type)
        {
            if (menues.TryGetValue(type, out Menu result))
                return result;

            Debug.Log($"[{nameof(MenuController)}]: {type} Menu not found!");

            return null;
        }

        private void InitMenues()
        {
            menues.Clear();

            if (InitMenuesFromRoot() == false)
            {
                Debug.Log($"[{nameof(MenuController)}]: Trying to load menu prefabs from resources.");

                InitMenuesFromResources();
            }
        }

        private void InitMenuesFromResources()
        {
            var menuPrefabs = Resources.LoadAll<Menu>("Prefabs/UI/Menues");

            if (menuPrefabs == null)
            {
                Debug.Log($"[{nameof(MenuController)}]: Menu prefabs not found!");
                return;
            }

            var result = new List<Menu>();
            for (var i = 0; i < menuPrefabs.Length; i++)
            {
                var menu = Instantiate(menuPrefabs[i], menuesRoot);
                menu.gameObject.SetActive(false);
                menu.name = menu.GetType().Name;
                menu.Init(this);

                menues.Add(menu.Type, menu);
            }
        }

        private bool InitMenuesFromRoot()
        {
            var menuComponents = menuesRoot.GetComponentsInChildren<Menu>(true);

            if (menuComponents == null || menuComponents.Length == 0)
            {
                Debug.Log($"[{nameof(MenuController)}]: No menu found in root!");
                return false;
            }

            foreach (Menu menu in menuComponents)
            {
                menu.gameObject.SetActive(false);
                menu.Init(this);

                menues.Add(menu.Type, menu);
            }

            return true;
        }
    }
}
