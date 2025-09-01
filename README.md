# ScriptableObject Data
A package that implements an architecture described in this Unite talk: https://www.youtube.com/watch?v=raQ3iHhE_Kk

Comes with an generic abstract Variable<T> class, making the system easy to customize and scale.
A serialized class, Reference<T>, allows elements to access variables as read-only. It also possesses an OnValueChanged Action<T> which is raised whenever the referenced variable has its value changed.
