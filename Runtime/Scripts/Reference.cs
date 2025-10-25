using System;

namespace com.simenbask.sod.Runtime
{
    [Serializable]
    public class Reference<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;
        public Variable<T> Variable;

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public void RegisterListener(Action<T> onValueChanged)
        {
            Variable.OnValueChanged += onValueChanged;
        }

        public void UnregisterListener(Action<T> onValueChanged)
        {
            Variable.OnValueChanged -= onValueChanged;
        }
    }
}
