using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour {

    public shipAI ShipAI;

    public float RadarRange;

    void Update()
    {
        gameObject.transform.localScale = Vector3.one * RadarRange;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy" && ShipAI.target == null)
        {
            ShipAI.target = col.gameObject;
        }
    }

}
