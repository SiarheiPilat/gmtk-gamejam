﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScroll : MonoBehaviour {

	void Update () {

        if(transform.position.y < -80.0f)
        {
            AddTile();
        }
	}

    //1
    //217.98

    void AddTile()
    {
        GameObject tile = Instantiate(gameObject, transform.position + new Vector3(0.0f, 254.75f, 0.0f), Quaternion.identity);
        Destroy(this);
    }
}
