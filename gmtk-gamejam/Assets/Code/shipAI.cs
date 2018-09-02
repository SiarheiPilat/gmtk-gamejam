using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipAI : MonoBehaviour {

    public GameObject shipProjectile;
    public GameObject target;

    private CircleCollider2D radar;

    private float counter;

    public float FireFrequency;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FiringMode();
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy" && target == null)
        {
            target = col.gameObject;
        }
    }

    void FiringMode()
    {
        if (target)
        {
            counter += Time.deltaTime;
            if(counter >= FireFrequency)
            {
                counter = 0.0f;
                FireProjectile();
            }
        }
    }

    void FireProjectile()
    {
        GameObject projectileClone = Instantiate(shipProjectile, transform.position, Quaternion.identity);
        projectileClone.GetComponent<shipProjectileAI>().SetTarget(target);
        target.GetComponent<health>().Damage((int)ShipStats.hitDamage);
    }
}
