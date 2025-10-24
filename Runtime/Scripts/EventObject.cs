using System;
using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    [CreateAssetMenu(fileName = "New EventObject", menuName = "ScriptableObject Data/Create new event object")]
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
