using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


namespace Rodrigo_.InputSystem
{
    [CreateAssetMenu(
        fileName = nameof(InputExecutionData),
        menuName = "Rodrigo_/InputSystem/InputExecutionData",
        order = -2000)]
    public sealed class InputExecutionData : ScriptableObject
    {
        [SerializeField] private InputActionReference _inputActionReference;
        public System.Action<object> OnCallbackValue;
        public UnityEvent OnKeyDown;
        public UnityEvent OnKeyUp;

        public void OnInitialize()
        {
            if (_inputActionReference == null) return;

            _inputActionReference.action.started += InputState;
            _inputActionReference.action.performed += InputState;
            _inputActionReference.action.canceled += InputState;
        }

        public void OnReset()
        {
            if (_inputActionReference == null) return;

            _inputActionReference.action.started -= InputState;
            _inputActionReference.action.performed -= InputState;
            _inputActionReference.action.canceled -= InputState;
        }

        private void InputState(InputAction.CallbackContext callbackContext)
        {
            object callBackValue = callbackContext.ReadValueAsObject();

            Debug.Log($"{nameof(InputExecutionData)} / Callback = {callBackValue} / {callbackContext.phase}");

            OnCallbackValue?.Invoke(callBackValue);

            switch (callbackContext.phase)
            {
                case InputActionPhase.Started:
                    OnKeyDown?.Invoke();
                    break;
                case InputActionPhase.Performed:
                    break;
                case InputActionPhase.Canceled:
                    OnKeyUp?.Invoke();
                    break;
            }
        }
    }
}