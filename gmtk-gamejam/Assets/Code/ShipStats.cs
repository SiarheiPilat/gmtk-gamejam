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

    private float hitDamage;
    private float awarnessOfDanger;
    private float speed;
    private float acceleration;
    private float armor;
    private float energy;
    private float life;
    private float lineOfSight;

    public float ShipHealth, ShipShield;

    int temp = 0, coin = 0;

    public GameObject manager;

    // Use this for initialization
    void Start () {
        RandomizeStats();

        SecondStatsCheck();

        manager.GetComponent<StatsUpdator>().UpdateStats(STR, DEX, CON, INT, WIS);
        manager.GetComponent<StatsUpdator>().UpdateHealthAndShield(ShipHealth, ShipShield);

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
		
	}
}
