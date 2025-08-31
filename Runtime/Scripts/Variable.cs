using System;
using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    public abstract class Variable<T> : ScriptableObject where T : IEquatable<T>
    {
        [SerializeField]
        protected T _value;

        public event Action<T> OnValueChanged;

        public T Value
        {
            get { return _value; }
            set
            {
                if (value.Equals(_value))
                {
                    _value = value;
                    OnValueChanged?.Invoke(_value);
                }
            }
        }
    }
}
