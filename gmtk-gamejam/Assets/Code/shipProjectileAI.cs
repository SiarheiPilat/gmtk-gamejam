using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipProjectileAI : MonoBehaviour {

    private Vector3 target;
    public float speed;

    void Start()
    {
        target += new Vector3(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range(-0.5f, 0.5f));
    }

    public void SetTarget(GameObject targ)
    {
        target = targ.transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(target, transform.position) > 0.1)
        {
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
        }
        else
        {
            //hurt
            Destroy(gameObject);
        }
    }
}
