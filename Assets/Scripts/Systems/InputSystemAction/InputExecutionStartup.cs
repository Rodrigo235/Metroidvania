using UnityEngine;

namespace Rodrigo_.InputSystem
{
    public sealed class InputExecutionStartup : MonoBehaviour
    {
        [SerializeField] private InputExecutionManagerData _inputExecutionManager;

        private void Awake()
        {
            _inputExecutionManager.OnInitialize();

            DontDestroyOnLoad(this);
        }

        private void OnDestroy()
        {
            
        }
    }
}