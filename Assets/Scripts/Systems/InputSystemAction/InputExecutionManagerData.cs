using System.Collections.Generic;
using UnityEngine;

namespace Rodrigo_.InputSystem
{
    [CreateAssetMenu(fileName = nameof(InputExecutionManagerData), menuName = "Rodrigo_/InputSystem/InputExecutionManagerData")]
    public sealed class InputExecutionManagerData : ScriptableObject
    {
        [SerializeField] private List<InputExecutionData> _inputExecutionDatas;

        public void OnInitialize()
        {
            foreach (InputExecutionData inputExecution in _inputExecutionDatas)
            {
                inputExecution.OnInitialize();
            }
        }

        public void OnReset()
        {
            foreach (InputExecutionData inputExecution in _inputExecutionDatas)
            {
                inputExecution.OnReset();
            }
        }
    }
}