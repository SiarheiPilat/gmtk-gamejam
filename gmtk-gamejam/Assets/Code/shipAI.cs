using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipAI : MonoBehaviour {

    public GameObject shipProjectile;
    public GameObject target;

    private CircleCollider2D radar;

    private float counter;

    public float FireFrequency;

    public AudioClip laser;

    private AudioSource audioSource;
    
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();

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
        audioSource.PlayOneShot(laser);
        GameObject projectileClone = Instantiate(shipProjectile, transform.position, Quaternion.identity);
        projectileClone.GetComponent<shipProjectileAI>().SetTarget(target);
        target.GetComponent<health>().Damage((int)ShipStats.hitDamage);
    }
}
