
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Rodrigo_.InputSystem
{
    public class InputExecutionJump : MonoBehaviour
    {
        [SerializeField] private InputExecutionData _inputExecutionData;

        public UnityEvent OnJump;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Awake()
        {
            if (_inputExecutionData == null) return;

            _inputExecutionData.OnKeyDown.AddListener(OnJumpPressed);
        }

        // Update is called once per frame
        void OnDestroy()
        {

        }

        public void OnJumpPressed()
        {
            OnJump?.Invoke();
        }
    }
}