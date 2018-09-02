using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTiler : MonoBehaviour {

    /// <summary>
    /// Should be negative value.
    /// </summary>
    public float ScrollSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= Vector3.down * ScrollSpeed;

        if (transform.position.y < -160.0f)
        {
            Destroy(gameObject);
        }
    }
}
