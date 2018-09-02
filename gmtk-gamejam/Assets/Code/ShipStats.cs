using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour {

    const int TotalPoints = 100;

    public static int STR; // Ship's Hit Damage
    public static int DEX; // Awareness of Danger, Speed and Acceleration
    public static int CON; // Ship's Armor
    public static int INT; // Ship's Energy and Life Amount
    public static int WIS; // Line of Sight [In Degrees or in Radius (depending on the Sight Component)]

    public static float hitDamage = 10;
    public static float awarnessOfDanger;
    public static float speed;
    public static float acceleration;
    public static float armor;
    public static float energy;
    public static float life;
    public static float lineOfSight;

    public static float ShipHealth, ShipShield;

    int temp = 0, coin = 0;

    public GameObject manager;

    public static GameObject staticManager;

    // Use this for initialization
    void Start () {
        staticManager = manager;
        RandomizeStats();

        SecondStatsCheck();

        ShipHealth = 100;
        ShipShield = 100;

        manager.GetComponent<StatsUpdator>().UpdateStats(STR, DEX, CON, INT, WIS);
        manager.GetComponent<StatsUpdator>().UpdateHealthAndShield(ShipHealth, ShipShield);

    }

    public static void UpdateHUD()
    {
        staticManager.GetComponent<StatsUpdator>().UpdateHealthAndShield(ShipHealth, ShipShield);
    }

    private void SecondStatsCheck()
    {
        if (CON > INT) armor *= 1.14f;
        if (INT > CON) life *= 1.12f;
    }

    private void RandomizeStats()
    {
        STR = UnityEngine.Random.Range(10, 21);
        DEX = UnityEngine.Random.Range(10, 21);
        CON = UnityEngine.Random.Range(10, 21);
        INT = UnityEngine.Random.Range(10, 21);
        WIS = UnityEngine.Random.Range(10, 21);
        temp = TotalPoints - (STR + DEX + CON + INT + WIS); // leftover points

        for (int i = 0; i < temp; i++)
        {
            CoinToss();
            switch (coin)
            {
                case 0:
                    STR++;
                    break;
                case 1:
                    DEX++;
                    break;
                case 2:
                    CON++;
                    break;
                case 3:
                    INT++;
                    break;
                case 4:
                    WIS++;
                    break;
            }
        }
    }

    private void CoinToss()
    {
        coin = UnityEngine.Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update () {
		if(ShipHealth <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        SendEnemiesHome();
        Destroy(gameObject, 0.1f);
    }

    void SendEnemiesHome()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy.GetComponent<enemyAI>());
            enemy.AddComponent<peacefulAI>();
        }
    }
}
