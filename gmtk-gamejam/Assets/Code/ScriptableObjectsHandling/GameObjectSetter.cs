using UnityEngine;

namespace ProtoFramework
{
    public class GameObjectSetter : MonoBehaviour
    {
        public GameObjectValue target;

        private void Awake()
        {
            target.value = gameObject;
        }
    }
}
