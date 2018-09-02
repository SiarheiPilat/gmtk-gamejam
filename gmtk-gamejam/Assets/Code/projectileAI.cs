using System;
using UnityEngine;

public class projectileAI : MonoBehaviour {

    public Vector3 target;
    public float TargetingDistance;
    public float speed;
    public int damage;

    void Start()
    {
        target += new Vector3(UnityEngine.Random.Range(-1.0f, 1.0f), UnityEngine.Random.Range(-1.0f, 1.0f));
    }

    void Update()
    {
        if (Vector3.Distance(target, transform.position) > TargetingDistance)
        {
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
        }
        else
        {
            DamageShip(damage);
            Destroy(gameObject);
        }
    }

    private void DamageShip(float dmg)
    {
        if(ShipStats.ShipShield == 0)
        {
            ShipStats.ShipHealth -= dmg;
            if(ShipStats.ShipHealth < 0)
            {
                ShipStats.ShipHealth = 0;
            }
        } else
        {
            ShipStats.ShipShield -= dmg;
            if(ShipStats.ShipShield < 0)
            {
                ShipStats.ShipShield = 0;
            }
        }
        ShipStats.UpdateHUD();
    }
}
