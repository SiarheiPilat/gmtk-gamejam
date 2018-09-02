using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRegenModule : Module {

    public GameObject actualShip;

	// Use this for initialization
	void Start () {
        actualShip = GameObject.Find("actual-ship");
	}

    public override void ApplyEffect()
    {
        actualShip.AddComponent<ShieldRegenerator>();
    }

    public override void RemoveEffect()
    {
        Destroy(actualShip.GetComponent<ShieldRegenerator>());
    }
}
