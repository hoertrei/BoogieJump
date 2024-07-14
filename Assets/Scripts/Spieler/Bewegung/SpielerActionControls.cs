// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Spieler/Bewegung/SpielerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SpielerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpielerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpielerControls"",
    ""maps"": [
        {
            ""name"": ""Block"",
            ""id"": ""833ceec5-b5e9-4c02-bf68-91fd79d97a21"",
            ""actions"": [
                {
                    ""name"": ""Bewegen"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2373bbf5-8a50-43d3-8833-98977b5e3271"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Springen"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba3cb44f-0a1a-424f-bdc1-f612eac7d113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Richtung WASD"",
                    ""id"": ""ba973c3c-2122-4f3e-84df-aa92e9be0e9d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""82ca8124-989f-46d6-a5bf-4658063578a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""efb99f24-3cc6-4d0f-8754-746d83ed8a93"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Richtung Pfeiltasten"",
                    ""id"": ""90d85056-ad4e-4139-816b-6d052d748335"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""31dfe9a6-9901-4ac9-a487-fd940a05722d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd7afcf3-fa93-49aa-8af0-d37b07afc1d3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bewegen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""56baebfd-2d79-4b74-8915-8ea722a94276"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Springen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""806c1151-ff6b-4b93-8490-27959938f1a4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Springen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Immer"",
            ""id"": ""c35339be-b7fe-48a3-80a2-8abe28b4c6f9"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b3266961-02d4-456f-9e03-d9c977de6f88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4108a287-3f4a-4476-a11b-c072011685d4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Block
        m_Block = asset.FindActionMap("Block", throwIfNotFound: true);
        m_Block_Bewegen = m_Block.FindAction("Bewegen", throwIfNotFound: true);
        m_Block_Springen = m_Block.FindAction("Springen", throwIfNotFound: true);
        // Immer
        m_Immer = asset.FindActionMap("Immer", throwIfNotFound: true);
        m_Immer_Pause = m_Immer.FindAction("Pause", throwIfNotFound: true);
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

    // Block
    private readonly InputActionMap m_Block;
    private IBlockActions m_BlockActionsCallbackInterface;
    private readonly InputAction m_Block_Bewegen;
    private readonly InputAction m_Block_Springen;
    public struct BlockActions
    {
        private @SpielerActionControls m_Wrapper;
        public BlockActions(@SpielerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bewegen => m_Wrapper.m_Block_Bewegen;
        public InputAction @Springen => m_Wrapper.m_Block_Springen;
        public InputActionMap Get() { return m_Wrapper.m_Block; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BlockActions set) { return set.Get(); }
        public void SetCallbacks(IBlockActions instance)
        {
            if (m_Wrapper.m_BlockActionsCallbackInterface != null)
            {
                @Bewegen.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnBewegen;
                @Bewegen.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnBewegen;
                @Bewegen.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnBewegen;
                @Springen.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnSpringen;
                @Springen.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnSpringen;
                @Springen.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnSpringen;
            }
            m_Wrapper.m_BlockActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bewegen.started += instance.OnBewegen;
                @Bewegen.performed += instance.OnBewegen;
                @Bewegen.canceled += instance.OnBewegen;
                @Springen.started += instance.OnSpringen;
                @Springen.performed += instance.OnSpringen;
                @Springen.canceled += instance.OnSpringen;
            }
        }
    }
    public BlockActions @Block => new BlockActions(this);

    // Immer
    private readonly InputActionMap m_Immer;
    private IImmerActions m_ImmerActionsCallbackInterface;
    private readonly InputAction m_Immer_Pause;
    public struct ImmerActions
    {
        private @SpielerActionControls m_Wrapper;
        public ImmerActions(@SpielerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Immer_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Immer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ImmerActions set) { return set.Get(); }
        public void SetCallbacks(IImmerActions instance)
        {
            if (m_Wrapper.m_ImmerActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_ImmerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ImmerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ImmerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_ImmerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public ImmerActions @Immer => new ImmerActions(this);
    public interface IBlockActions
    {
        void OnBewegen(InputAction.CallbackContext context);
        void OnSpringen(InputAction.CallbackContext context);
    }
    public interface IImmerActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
