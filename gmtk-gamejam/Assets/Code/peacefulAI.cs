using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peacefulAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.up * 0.01f;
	}
}
