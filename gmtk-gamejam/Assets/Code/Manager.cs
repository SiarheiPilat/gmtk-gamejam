using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static int HighlightedCellsAmount;

    public static List<GameObject> HighlightedGameobjects;

    public static bool ItemCanBeInstalled;

    public GameObject marker;

    public List<GameObject> testGos;

	void Start () {
        ItemCanBeInstalled = true;
        HighlightedGameobjects = new List<GameObject>();
        HighlightedCellsAmount = 0;

        //marker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //marker.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        Debug.Log(MinX(testGos));
    }
	
	void Update () {

        //Debug.Log("Highlited cells: " + HighlightedCellsAmount + " | Array length: " + HighlightedGameobjects.Count + " | Can install: " + ItemCanBeInstalled);
        //Debug.Log(HighlightedGameobjects.Count);
        if (HighlightedGameobjects.Count > 0)
        {
            //marker.transform.position = 
        }
    }


    ////taken from https://answers.unity.com/questions/511841/how-to-make-an-object-move-away-from-three-or-more.html
    //private Vector3 FindCenterPoint(List<GameObject> gos)
    //{
    //    if (gos.Count == 0)
    //        return Vector3.zero;
    //    if (gos.Count == 1)
    //        return gos[0].transform.position;
    //    var bounds = new Bounds(gos[0].transform.position, Vector3.zero);
    //    for (var i = 1; i < gos.Count; i++)
    //        bounds.Encapsulate(gos[i].transform.position);
    //    return bounds.center;
    //}

    public static void Reset()
    {
        HighlightedGameobjects.Clear();
        HighlightedCellsAmount = 0;
    }

    public static float MinX(List<GameObject> gos)
    {
        float minValue = 0.0f;
        if (gos.Count == 1)
            return gos[0].GetComponent<RectTransform>().anchoredPosition.x;
        if(gos.Count > 1)
        {
            minValue = gos[0].GetComponent<RectTransform>().anchoredPosition.x;
            for (int i = 1; i < gos.Count; i++)
            {
                if(gos[i].GetComponent<RectTransform>().anchoredPosition.x < minValue)
                {
                    minValue = gos[i].GetComponent<RectTransform>().anchoredPosition.x;
                }
            }
        }
        return minValue;
    }

    public static Vector3 MidPoint(float x1, float x2, float y1, float y2)
    {
        return new Vector3((x1 + x2) / 2.0f, (y1 + y2) / 2.0f, 0.0f);
    }
}
