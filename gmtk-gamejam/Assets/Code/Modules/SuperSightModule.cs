using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSightModule : Module {

    public GameObject radar;
    private float StandardRadarRange;

    void Start()
    {
        radar = GameObject.Find("fog-of-war");
        StandardRadarRange = radar.GetComponent<Radar>().RadarRange;
    }

    public override void ApplyEffect()
    {
        radar.GetComponent<Radar>().RadarRange = 1000;
    }

    public override void RemoveEffect()
    {
        radar.GetComponent<Radar>().RadarRange = StandardRadarRange;
    }
}
