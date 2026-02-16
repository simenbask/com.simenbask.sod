using System;
using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    public abstract class EventObject<T> : ScriptableObject
    {
        public event Action<T> OnEvent;

        public void RegisterListener(Action<T> onEvent)
        {
            OnEvent += onEvent;
        }

        public void UnregisterListener(Action<T> onEvent)
        {
            OnEvent -= onEvent;
        }

        public void Raise(T param)
        {
            OnEvent?.Invoke(param);
        }
    }
}
