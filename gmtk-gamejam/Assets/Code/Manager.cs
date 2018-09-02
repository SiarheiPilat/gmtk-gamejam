using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static List<GameObject> TriggeredCells; // cells that we hover over with an item

    //REMOVED
    //public static bool CanInstall;
    public static Item SelectedItem;

	void Start () {
        //CanInstall = false; // the item can not be installed from the start
        TriggeredCells = new List<GameObject>();
    }
	
	void Update () {

        //Debug.Log("Highlited cells: " + HighlightedCellsAmount + " | Array length: " + HighlightedGameobjects.Count + " | Can install: " + ItemCanBeInstalled);
        //Debug.Log(CanInstall);
    }

    public static void Reset()
    {
        TriggeredCells.Clear();
        //CanInstall = false;
        SelectedItem = null;
    }
}
