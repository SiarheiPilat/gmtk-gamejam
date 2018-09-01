using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Taken from https://www.youtube.com/watch?v=raQ3iHhE_Kk
/// </summary>

namespace ProtoFramework
{
    public class GameEventListener : MonoBehaviour
    {

        public GameEvent Event;
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}