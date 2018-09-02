using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRegenerator : MonoBehaviour {

    private static float timer;

    public GameObject shieldText;

	// Use this for initialization
	void Start () {
        shieldText = Manager.ShieldText;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 2.0f)
        {
            if(ShipStats.ShipShield < 100)
            {
                ShipStats.ShipShield += 5;
                GameObject shieldTextClone = Instantiate(shieldText, transform.position, Quaternion.identity);
                Debug.Log("generated");
            }
            if (ShipStats.ShipShield > 100)
            {
                Debug.Log("max shield");
                ShipStats.ShipShield = 100;
            }
            ShipStats.UpdateHUD();
            timer = 0.0f;
        }
	}
}
