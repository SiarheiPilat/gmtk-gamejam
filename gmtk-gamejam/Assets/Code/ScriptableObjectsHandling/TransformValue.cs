using UnityEngine;

namespace ProtoFramework
{
    [CreateAssetMenu(fileName = "TransformValue", menuName = "Prototyper/Transform Value", order = 6)]
    public class TransformValue : ScriptableObject
    {
        [HideInInspector] public Transform value;
    }
}
