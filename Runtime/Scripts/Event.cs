using System;
using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    [CreateAssetMenu(fileName = "New Event", menuName = "ScriptableObject Data/Create new event")]
    public class Event : ScriptableObject
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
