using UnityEngine;

namespace ProtoFramework
{
    [CreateAssetMenu(fileName = "GameObjectValue", menuName = "Prototyper/GameObject Value", order = 6)]
    public class GameObjectValue : ScriptableObject
    {
        [HideInInspector] public GameObject value;
    }
}
