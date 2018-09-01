﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Taken from https://www.youtube.com/watch?v=raQ3iHhE_Kk
/// Register/unregister logic borrowed from https://www.youtube.com/watch?v=rgyUC2fLC-I
/// </summary>

namespace ProtoFramework
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "Prototyper/GameEvent", order = 6)]
    public class GameEvent : ScriptableObject
    {

        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
            else Debug.LogWarning("Listener reregistered to event");
        }

        public void UnregisterListener(GameEventListener listener)
        {
            listeners.Remove(listener);
        }
    }
}