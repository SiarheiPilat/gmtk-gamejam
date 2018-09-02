using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            GetComponent<Item>().CanInstall = true;
        }
        else
        {
            GetComponent<Item>().CanInstall = false;
        }
            
    }

    void OnTriggerExit(Collider other)
    {

    }
}
