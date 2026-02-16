using System;
using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    [CreateAssetMenu(fileName = "New EventObject", menuName = "ScriptableObject Data/Events/Create new empty event")]
    public class EventObject : ScriptableObject
    {
        public event Action OnEvent;

        public void RegisterListener(Action onEvent)
        {
            OnEvent += onEvent;
        }

        public void UnregisterListener(Action onEvent)
        {
            OnEvent -= onEvent;
        }

        public void Raise()
        {
            OnEvent?.Invoke();
        }
    }
}
