using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyModule : Module {

    public override void ApplyEffect()
    {
        Debug.Log("this module does nothing");
    }

    public override void RemoveEffect()
    {
        Debug.Log("this module does nothing");
    }
}
