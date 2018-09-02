using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// All kinds of math and utility functions.
/// </summary>
public class Utils : MonoBehaviour {

    public GameObject[] testGos;
    public GameObject marker; // for testing

    // Use this for initialization
    void Start () {
        //Debug.Log("minx: " + MinX(testGos) + " miny: " + MinY(testGos) + " maxx: " + MaxX(testGos) + " maxy: " + MaxY(testGos));
        //marker.GetComponent<RectTransform>().anchoredPosition = MidPoint(MinX(testGos), MaxX(testGos), MinY(testGos), MaxY(testGos));
	}

    // read more https://answers.unity.com/questions/511841/how-to-make-an-object-move-away-from-three-or-more.html

    public static float MinX(GameObject[] gos)
    {
        float minValue = 0.0f;
        if (gos.Length == 1)
            return gos[0].GetComponent<RectTransform>().anchoredPosition.x; //NullRef here sometimes
        if (gos.Length > 1)
        {
            minValue = gos[0].GetComponent<RectTransform>().anchoredPosition.x;
            for (int i = 1; i < gos.Length; i++)
            {
                if (gos[i].GetComponent<RectTransform>().anchoredPosition.x < minValue)
                {
                    minValue = gos[i].GetComponent<RectTransform>().anchoredPosition.x;
                }
            }
        }
        return minValue;
    }

    public static float MinY(GameObject[] gos)
    {
        float minValue = 0.0f;
        if (gos.Length == 1)
            return gos[0].GetComponent<RectTransform>().anchoredPosition.y;
        if (gos.Length > 1)
        {
            minValue = gos[0].GetComponent<RectTransform>().anchoredPosition.y;
            for (int i = 1; i < gos.Length; i++)
            {
                if (gos[i].GetComponent<RectTransform>().anchoredPosition.y < minValue)
                {
                    minValue = gos[i].GetComponent<RectTransform>().anchoredPosition.y;
                }
            }
        }
        return minValue;
    }

    public static float MaxY(GameObject[] gos)
    {
        float maxValue = 0.0f;
        if (gos.Length == 1)
            return gos[0].GetComponent<RectTransform>().anchoredPosition.y;
        if (gos.Length > 1)
        {
            maxValue = gos[0].GetComponent<RectTransform>().anchoredPosition.y;
            for (int i = 1; i < gos.Length; i++)
            {
                if (gos[i].GetComponent<RectTransform>().anchoredPosition.y > maxValue)
                {
                    maxValue = gos[i].GetComponent<RectTransform>().anchoredPosition.y;
                }
            }
        }
        return maxValue;
    }

    public static float MaxX(GameObject[] gos)
    {
        float maxValue = 0.0f;
        if (gos.Length == 1)
            return gos[0].GetComponent<RectTransform>().anchoredPosition.x;
        if (gos.Length > 1)
        {
            maxValue = gos[0].GetComponent<RectTransform>().anchoredPosition.x;
            for (int i = 1; i < gos.Length; i++)
            {
                if (gos[i].GetComponent<RectTransform>().anchoredPosition.x > maxValue)
                {
                    maxValue = gos[i].GetComponent<RectTransform>().anchoredPosition.x;
                }
            }
        }
        return maxValue;
    }

    private static Vector2 MidPoint(float x1, float x2, float y1, float y2)
    {
        return new Vector2((x1 + x2) / 2.0f, (y1 + y2) / 2.0f);
    }
    
    // BUG: NullReferenceException is fired up around line 32 sometimes
    public static Vector2 MidPoint(GameObject[] gos)
    {
        return MidPoint(MinX(gos), MaxX(gos), MinY(gos), MaxY(gos));
    }
}
