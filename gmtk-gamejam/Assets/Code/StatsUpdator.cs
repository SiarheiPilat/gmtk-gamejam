using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUpdator : MonoBehaviour {

    public GameObject strText;
    public GameObject dexText;
    public GameObject conText;
    public GameObject intText;
    public GameObject wisText;

    public GameObject healthText, shieldText;

    public GameObject ship;

    public void UpdateSTR(int val)
    {
        ShipStats.STR = val;
        strText.GetComponent<Text>().text = "STR: " + val.ToString();
    }

    public void UpdateDEX(int val)
    {
        ShipStats.DEX = val;
        dexText.GetComponent<Text>().text = "DEX: " + val.ToString();
    }

    public void UpdateCON(int val)
    {
        ShipStats.CON = val;
        conText.GetComponent<Text>().text = "CON: " + val.ToString();
    }

    public void UpdateINT(int val)
    {
        ShipStats.INT = val;
        intText.GetComponent<Text>().text = "INT: " + val.ToString();
    }

    public void UpdateWIS(int val)
    {
        ShipStats.WIS = val;
        wisText.GetComponent<Text>().text = "WIS: " + val.ToString();
    }

    internal void UpdateHealthAndShield(float shipHealth, float shipShield)
    {
        UpdateShield(shipShield);
        UpdateHealth(shipHealth);
    }

    public void UpdateShield(float val)
    {
        shieldText.GetComponent<Text>().text = "Shield: " + val.ToString();
    }

    public void UpdateHealth(float val)
    {
        healthText.GetComponent<Text>().text = "Health: " + val.ToString();
    }

    internal void UpdateStats(int STR, int DEX, int CON, int INT, int WIS)
    {
        UpdateSTR(STR);
        UpdateDEX(DEX);
        UpdateCON(CON);
        UpdateINT(INT);
        UpdateWIS(WIS);
    }
}
