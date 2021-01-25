// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Scripts/Concretes/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace AlgebraGlobalPrototyle.Inputs
{
    public class @MyInputAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MyInputAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""bc0811e6-c10b-4209-a2b2-4a343e48f1ae"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e1246ac7-1a2e-4614-996d-51a87d06cba8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.01)""
                },
                {
                    ""name"": ""ClickPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bbbed036-a79f-4452-ba71-52306b6f925c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df82290d-01c0-4d3f-955c-b40aa54b1c0a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76e661a5-a622-4d5f-9df1-9975d84ebbb8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // OnFoot
            m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
            m_OnFoot_Click = m_OnFoot.FindAction("Click", throwIfNotFound: true);
            m_OnFoot_ClickPosition = m_OnFoot.FindAction("ClickPosition", throwIfNotFound: true);
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

        // OnFoot
        private readonly InputActionMap m_OnFoot;
        private IOnFootActions m_OnFootActionsCallbackInterface;
        private readonly InputAction m_OnFoot_Click;
        private readonly InputAction m_OnFoot_ClickPosition;
        public struct OnFootActions
        {
            private @MyInputAction m_Wrapper;
            public OnFootActions(@MyInputAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_OnFoot_Click;
            public InputAction @ClickPosition => m_Wrapper.m_OnFoot_ClickPosition;
            public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
            public void SetCallbacks(IOnFootActions instance)
            {
                if (m_Wrapper.m_OnFootActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClick;
                    @ClickPosition.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClickPosition;
                    @ClickPosition.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClickPosition;
                    @ClickPosition.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnClickPosition;
                }
                m_Wrapper.m_OnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ClickPosition.started += instance.OnClickPosition;
                    @ClickPosition.performed += instance.OnClickPosition;
                    @ClickPosition.canceled += instance.OnClickPosition;
                }
            }
        }
        public OnFootActions @OnFoot => new OnFootActions(this);
        public interface IOnFootActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnClickPosition(InputAction.CallbackContext context);
        }
    }
}
