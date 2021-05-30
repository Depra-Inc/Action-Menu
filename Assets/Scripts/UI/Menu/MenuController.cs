using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FD.UI.Menues
{
    using Input;

    [AddComponentMenu("FD/UI/Menu/Menu Controller")]
    [DisallowMultipleComponent]
    internal class MenuController : MonoBehaviour, IMenuController
    {
        [SerializeField] Transform menuesRoot = null;

        public Menu[] Menues => menues.Values.ToArray();

        public Action GameStarted { get; set; }
        public Action GameEnded { get; set; }
        public Action<Menu> MenuOpened { get; set; }
        public Action<Menu> MenuClosed { get; set; }

        private Stack<Menu> menuStack = new Stack<Menu>();
        private Dictionary<int, Menu> menues = new Dictionary<int, Menu>();

        private void Awake()
        {
            InputManager.Add(ActionMapNames.UI);
            InputManager.Controls.UI.Enable();

            InitMenues();
            OpenMenu(MenuType.Main);

            MenuOpened += OnMenuOpened;
            MenuClosed += OnMenuClosed;
        }

        private void OnDestroy()
        {
            InputManager.Remove(ActionMapNames.UI);
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
            OpenMenu(GetMenu(type));
        }

        public void OpenMenu(Menu menu)
        {
            if (menu == null)
                return;

            menu.Open();
        }

        public void OnMenuOpened(Menu menu)
        {
            menuStack.Push(menu);
        }

        public void OnMenuClosed(Menu menu)
        {
            if (menuStack.Count == 0)
                return;

            menuStack.Pop();
        }

        public void ToggleMenu(Menu menu)
        {
            if (menu == null)
                return;

            menu.Toggle();
        }

        public void CloseLastMenu()
        {
            if (menuStack.Count == 0)
                return;

            var lastMenu = menuStack.Peek();
            if (lastMenu is MainMenu)
                return;

            lastMenu.Close();
        }

        public void CloseMenu(Menu menu)
        {
            if (menu == null)
                return;

            menu.Close();

            var lastMenu = menuStack.Peek();
            if (menu == lastMenu)
                menuStack.Pop();
        }

        private Menu GetMenu(MenuType type)
        {
            var index = (int)type;
            if (menues.ContainsKey(index))
            {
                if (menues.TryGetValue(index, out Menu result))
                    return result;
            }

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

                menues.Add((int)menu.Type, menu);
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

                menues.Add((int)menu.Type, menu);
            }

            return true;
        }
    }
}
