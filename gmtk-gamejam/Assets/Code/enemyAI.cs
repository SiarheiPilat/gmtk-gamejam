using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {

    public Vector3 target;
    public float TargetingDistance;
    public float speed;

    public GameObject projectile;

    private float timer;

    public float attackFrequency;

    public int damage;

	void Start () {
        CalibrateTarget();
	}

    void CalibrateTarget()
    {
        target += new Vector3(UnityEngine.Random.Range(-3.0f, 3.0f), UnityEngine.Random.Range(-1.0f, 3.0f));
    }
	
	void Update () {

		if(Vector3.Distance(target, transform.position) > TargetingDistance)
        {
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
        } else
        {
            AttackBehaviour();
        }
	}

    private void AttackBehaviour()
    {
        timer += Time.deltaTime;
        if(timer > attackFrequency)
        {
            Attack();
            timer = 0;
        }
    }

    private void Attack()
    {
        GameObject ProjectileClone = Instantiate(projectile, transform.position, Quaternion.identity);
        ProjectileClone.GetComponent<projectileAI>().damage = damage;
    }
}
