// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace FD.Input
{
    public class @Controls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e696fa4a-be19-44bf-b1d2-56d205a33eff"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""dec723d2-1cfa-47fb-bfd6-3d116802f155"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""60900bb6-f570-4a83-9805-cb16ae56043e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""84d72448-1bcb-4dce-b57c-127232529424"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""dffd36a8-1c1a-447f-b9c6-112fd2c24fe0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""6a317db8-af07-4578-8d5f-c2e03de7d2bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""QuickTurn"",
                    ""type"": ""Button"",
                    ""id"": ""647565be-4f95-4b3c-87a2-059afaead0d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""9b9e75d5-81d3-48e8-b624-9063d984bd07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""cdbb42c9-3e19-4463-bf80-ad13e81036e5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""27251a92-914f-4dfc-acf9-8f08330181fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MeleeAttack"",
                    ""type"": ""Button"",
                    ""id"": ""039f8ac8-dfe7-42be-9829-3a0e71947514"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Suicide"",
                    ""type"": ""Button"",
                    ""id"": ""17b7bb30-c43c-40d6-897f-ea4b190e6825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f0b67169-4990-4cdc-8e20-85b0031143b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ScoreBoard"",
                    ""type"": ""Button"",
                    ""id"": ""79f58215-80e9-4bbc-8c5b-348742dd5743"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c476a3af-2cd5-4832-ba8d-5958da6d102d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""370e9548-a7f0-4c6b-af0b-90f9422f6951"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5d7a7a4-d992-4e31-b6a2-0e3ee9bf4c52"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc93444f-61de-4790-ae90-80265d53e504"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ScrollWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""836e52e5-1ef4-469d-b649-3b018e491f09"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale"",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77b7b915-ce8d-4560-acfb-70b267b1df77"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""301926a9-1905-4717-8e8f-8fa53cf5373a"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d64d70f-dff8-43bc-963d-852cb3acce0f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cb0b4b5-1bcb-47b8-96c5-64bc4c62fad1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""QuickTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5010b70-cb15-4eae-a33e-92d270b7da69"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c659129-2c45-421c-81f8-0e22d6902ffa"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""92d2af0d-0ee2-4d5a-9665-a01ac0f8b807"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2e65ebd-aa47-4f2c-98bf-8b9c318920e7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc9da633-504c-48e5-af29-4f4cd156aed7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""40dd73e2-b8a3-49f7-b616-e26f1d622bf6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c85813f9-f6da-4a89-9a70-d9ec7234b1d7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4eee58b6-bee7-44c4-93bd-59def40a4f8b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b0299c79-b73a-411a-9aa6-d98e77189faf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0c331e8-ee66-42d7-acab-836949c9d7b8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2d5b2e2e-0b07-479d-bd92-754b483e7f76"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f06919c-e8e4-4b98-a8a9-d1c232484048"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c23fada-e823-4d6d-b5ad-9393089cdf47"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ScoreBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6386eb4e-eb24-4cf2-82d0-6dfd3d036a23"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Suicide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""697c4eb8-173c-4101-b2ea-1b61044e2f93"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""1f5618c5-acf9-493f-ab5d-c61ba7c60c6b"",
            ""actions"": [
                {
                    ""name"": ""PreviousTab"",
                    ""type"": ""Button"",
                    ""id"": ""e9aeefbd-4ffc-4b06-8d77-a270228dc2b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""NextTab"",
                    ""type"": ""Button"",
                    ""id"": ""6ab33dfc-a1a8-4e08-9c86-0abb3555c1c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""CloseLast"",
                    ""type"": ""Button"",
                    ""id"": ""e6a91fd2-ee7e-4e02-918e-86c7fb313dfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2864309-f7b6-481b-8bd8-f90f9c7afb86"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PreviousTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""693c8e67-57d0-4498-9456-09f72b18dfcd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""NextTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97f2d900-78b4-466c-aea3-10367685e3ba"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CloseLast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Console"",
            ""id"": ""82d2b257-8f92-4e50-a8ef-00c4e8872e6c"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""DebugMenu"",
            ""id"": ""71fa63c7-e672-4997-80de-46e30e6796f4"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_Zoom = m_Player.FindAction("Zoom", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
            m_Player_QuickTurn = m_Player.FindAction("QuickTurn", throwIfNotFound: true);
            m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
            m_Player_ScrollWeapon = m_Player.FindAction("ScrollWeapon", throwIfNotFound: true);
            m_Player_SwitchWeapon = m_Player.FindAction("SwitchWeapon", throwIfNotFound: true);
            m_Player_MeleeAttack = m_Player.FindAction("MeleeAttack", throwIfNotFound: true);
            m_Player_Suicide = m_Player.FindAction("Suicide", throwIfNotFound: true);
            m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
            m_Player_ScoreBoard = m_Player.FindAction("ScoreBoard", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_PreviousTab = m_UI.FindAction("PreviousTab", throwIfNotFound: true);
            m_UI_NextTab = m_UI.FindAction("NextTab", throwIfNotFound: true);
            m_UI_CloseLast = m_UI.FindAction("CloseLast", throwIfNotFound: true);
            // Console
            m_Console = asset.FindActionMap("Console", throwIfNotFound: true);
            // DebugMenu
            m_DebugMenu = asset.FindActionMap("DebugMenu", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_Zoom;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Crouch;
        private readonly InputAction m_Player_QuickTurn;
        private readonly InputAction m_Player_Shoot;
        private readonly InputAction m_Player_ScrollWeapon;
        private readonly InputAction m_Player_SwitchWeapon;
        private readonly InputAction m_Player_MeleeAttack;
        private readonly InputAction m_Player_Suicide;
        private readonly InputAction m_Player_Pause;
        private readonly InputAction m_Player_ScoreBoard;
        public struct PlayerActions
        {
            private @Controls m_Wrapper;
            public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Look => m_Wrapper.m_Player_Look;
            public InputAction @Zoom => m_Wrapper.m_Player_Zoom;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
            public InputAction @QuickTurn => m_Wrapper.m_Player_QuickTurn;
            public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
            public InputAction @ScrollWeapon => m_Wrapper.m_Player_ScrollWeapon;
            public InputAction @SwitchWeapon => m_Wrapper.m_Player_SwitchWeapon;
            public InputAction @MeleeAttack => m_Wrapper.m_Player_MeleeAttack;
            public InputAction @Suicide => m_Wrapper.m_Player_Suicide;
            public InputAction @Pause => m_Wrapper.m_Player_Pause;
            public InputAction @ScoreBoard => m_Wrapper.m_Player_ScoreBoard;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Zoom.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                    @Zoom.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                    @Zoom.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @QuickTurn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickTurn;
                    @QuickTurn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickTurn;
                    @QuickTurn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickTurn;
                    @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @ScrollWeapon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeapon;
                    @ScrollWeapon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeapon;
                    @ScrollWeapon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeapon;
                    @SwitchWeapon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeapon;
                    @SwitchWeapon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeapon;
                    @SwitchWeapon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeapon;
                    @MeleeAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
                    @MeleeAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
                    @MeleeAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
                    @Suicide.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Suicide.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Suicide.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @ScoreBoard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                    @ScoreBoard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                    @ScoreBoard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Zoom.started += instance.OnZoom;
                    @Zoom.performed += instance.OnZoom;
                    @Zoom.canceled += instance.OnZoom;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @QuickTurn.started += instance.OnQuickTurn;
                    @QuickTurn.performed += instance.OnQuickTurn;
                    @QuickTurn.canceled += instance.OnQuickTurn;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                    @ScrollWeapon.started += instance.OnScrollWeapon;
                    @ScrollWeapon.performed += instance.OnScrollWeapon;
                    @ScrollWeapon.canceled += instance.OnScrollWeapon;
                    @SwitchWeapon.started += instance.OnSwitchWeapon;
                    @SwitchWeapon.performed += instance.OnSwitchWeapon;
                    @SwitchWeapon.canceled += instance.OnSwitchWeapon;
                    @MeleeAttack.started += instance.OnMeleeAttack;
                    @MeleeAttack.performed += instance.OnMeleeAttack;
                    @MeleeAttack.canceled += instance.OnMeleeAttack;
                    @Suicide.started += instance.OnSuicide;
                    @Suicide.performed += instance.OnSuicide;
                    @Suicide.canceled += instance.OnSuicide;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @ScoreBoard.started += instance.OnScoreBoard;
                    @ScoreBoard.performed += instance.OnScoreBoard;
                    @ScoreBoard.canceled += instance.OnScoreBoard;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_PreviousTab;
        private readonly InputAction m_UI_NextTab;
        private readonly InputAction m_UI_CloseLast;
        public struct UIActions
        {
            private @Controls m_Wrapper;
            public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @PreviousTab => m_Wrapper.m_UI_PreviousTab;
            public InputAction @NextTab => m_Wrapper.m_UI_NextTab;
            public InputAction @CloseLast => m_Wrapper.m_UI_CloseLast;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @PreviousTab.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                    @PreviousTab.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                    @PreviousTab.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                    @NextTab.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                    @NextTab.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                    @NextTab.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                    @CloseLast.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseLast;
                    @CloseLast.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseLast;
                    @CloseLast.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseLast;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PreviousTab.started += instance.OnPreviousTab;
                    @PreviousTab.performed += instance.OnPreviousTab;
                    @PreviousTab.canceled += instance.OnPreviousTab;
                    @NextTab.started += instance.OnNextTab;
                    @NextTab.performed += instance.OnNextTab;
                    @NextTab.canceled += instance.OnNextTab;
                    @CloseLast.started += instance.OnCloseLast;
                    @CloseLast.performed += instance.OnCloseLast;
                    @CloseLast.canceled += instance.OnCloseLast;
                }
            }
        }
        public UIActions @UI => new UIActions(this);

        // Console
        private readonly InputActionMap m_Console;
        private IConsoleActions m_ConsoleActionsCallbackInterface;
        public struct ConsoleActions
        {
            private @Controls m_Wrapper;
            public ConsoleActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputActionMap Get() { return m_Wrapper.m_Console; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ConsoleActions set) { return set.Get(); }
            public void SetCallbacks(IConsoleActions instance)
            {
                if (m_Wrapper.m_ConsoleActionsCallbackInterface != null)
                {
                }
                m_Wrapper.m_ConsoleActionsCallbackInterface = instance;
                if (instance != null)
                {
                }
            }
        }
        public ConsoleActions @Console => new ConsoleActions(this);

        // DebugMenu
        private readonly InputActionMap m_DebugMenu;
        private IDebugMenuActions m_DebugMenuActionsCallbackInterface;
        public struct DebugMenuActions
        {
            private @Controls m_Wrapper;
            public DebugMenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputActionMap Get() { return m_Wrapper.m_DebugMenu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DebugMenuActions set) { return set.Get(); }
            public void SetCallbacks(IDebugMenuActions instance)
            {
                if (m_Wrapper.m_DebugMenuActionsCallbackInterface != null)
                {
                }
                m_Wrapper.m_DebugMenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                }
            }
        }
        public DebugMenuActions @DebugMenu => new DebugMenuActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnZoom(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnQuickTurn(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnScrollWeapon(InputAction.CallbackContext context);
            void OnSwitchWeapon(InputAction.CallbackContext context);
            void OnMeleeAttack(InputAction.CallbackContext context);
            void OnSuicide(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnScoreBoard(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnPreviousTab(InputAction.CallbackContext context);
            void OnNextTab(InputAction.CallbackContext context);
            void OnCloseLast(InputAction.CallbackContext context);
        }
        public interface IConsoleActions
        {
        }
        public interface IDebugMenuActions
        {
        }
    }
}
