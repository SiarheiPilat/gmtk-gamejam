using ProtoFramework;
using System;
using UnityEngine;

public class ScriptableOverseer : MonoBehaviour {

    [Serializable]
    public struct GameObjectReference
    {
        public GameObject go;
        public GameObjectValue gov;
    }
    public GameObjectReference[] gameobjects;

    void Start () {
        for (int i = 0; i < gameobjects.Length; i++)
        {
            gameobjects[i].gov.value = gameobjects[i].go;
        }	
	}
}
