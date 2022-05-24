// GENERATED AUTOMATICALLY FROM 'Assets/imput/controles.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controles : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controles"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""55260d24-2aef-4b55-94e5-42c860443990"",
            ""actions"": [
                {
                    ""name"": ""movimento"",
                    ""type"": ""Value"",
                    ""id"": ""6de6c24a-a8e0-4a5d-a54e-57489c1d7a8c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""setas"",
                    ""id"": ""8e13f56f-e761-4389-a43c-3553687a10dc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""51580854-fc86-4ed1-92bb-8bee30db0e10"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed588759-4517-448d-9e23-0b3b1edb6072"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""670cb66b-e535-4444-850f-617a9f1b8bea"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""201ed6be-16dd-40b6-b9b0-9f16da7e1474"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""teclado"",
            ""bindingGroup"": ""teclado"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_movimento = m_gameplay.FindAction("movimento", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_movimento;
    public struct GameplayActions
    {
        private @Controles m_Wrapper;
        public GameplayActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @movimento => m_Wrapper.m_gameplay_movimento;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @movimento.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimento;
                @movimento.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimento;
                @movimento.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovimento;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movimento.started += instance.OnMovimento;
                @movimento.performed += instance.OnMovimento;
                @movimento.canceled += instance.OnMovimento;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    private int m_tecladoSchemeIndex = -1;
    public InputControlScheme tecladoScheme
    {
        get
        {
            if (m_tecladoSchemeIndex == -1) m_tecladoSchemeIndex = asset.FindControlSchemeIndex("teclado");
            return asset.controlSchemes[m_tecladoSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMovimento(InputAction.CallbackContext context);
    }
}
