using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldTextLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0.0f, 0.01f, 0.0f);
	}
}
