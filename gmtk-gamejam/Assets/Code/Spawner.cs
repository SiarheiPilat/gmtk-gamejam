using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public int SpawnHowMany;

    public GameObject EnemyPrefab;

    public Transform[] SpawnPoints;

    public void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, RandomSpawnPoint().position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-1.0f, 1.0f)), Quaternion.identity);
    }

    Transform RandomSpawnPoint()
    {
        return SpawnPoints[Random.Range(0, SpawnPoints.Length)];
    }

    public void SpawnWave(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            SpawnEnemy();
        }
    }

	// Use this for initialization
	void Start () {
        SpawnWave(SpawnHowMany);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
