using UnityEngine;
using UnityEngine.Events;

namespace Rodrigo_.InputSystem
{
    public sealed class InputExecutionMoveListener : MonoBehaviour
    {
        [SerializeField] private InputExecutionData _inputExecutionData;

        public UnityEvent<Vector2> OnVector2Value;

        private void Awake()
        {
            if (_inputExecutionData == null) return;

            _inputExecutionData.OnCallbackValue += GetMoveInput;
        }

        private void OnDestroy()
        {
            if (_inputExecutionData == null) return;

            _inputExecutionData.OnCallbackValue -= GetMoveInput;
        }

        public void GetMoveInput (object callbackValue)
        {
            switch (callbackValue)
            {
                case Vector2 vector2Value:
                    OnVector2Value?.Invoke(vector2Value);
                    break;

                default:
                    OnVector2Value?.Invoke(Vector2.zero);
                    break;
            }
        }
    }
}