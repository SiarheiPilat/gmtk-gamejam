using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static List<GameObject> TriggeredCells; // cells that we hover over with an item

    public static bool CanInstall;
    public static Item SelectedItem;

    [Header("---Debugging only---")]

    public GameObject selectedItem;
    public int NumberOfCells;

	void Start () {
        CanInstall = true; // the item can be installed from the start
        TriggeredCells = new List<GameObject>();
    }
	
	void Update () {

        if(SelectedItem)
            selectedItem = SelectedItem.gameObject;
        NumberOfCells = TriggeredCells.Count;
    }

    public static void Reset()
    {
        TriggeredCells.Clear();
        CanInstall = false;
        SelectedItem = null;
    }
}
