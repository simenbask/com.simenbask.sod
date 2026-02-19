using UnityEngine;

namespace com.simenbask.sod.Runtime
{
    [CreateAssetMenu(fileName = "New String Variable", menuName = "ScriptableObject Data/Variables/Create new string var")]
    public class StringVariable : Variable<string>
    {
        [SerializeField, TextArea(5,20)]
        new protected string _value;
    }
}
