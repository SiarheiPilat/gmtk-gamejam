using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

    public int Health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Health <= 0)
        {
            Die();
        }

	}

    public void Damage(int amount)
    {
        Health -= amount;
    }

    private void Die()
    {
        Destroy(gameObject, 1.0f);
    }
}
