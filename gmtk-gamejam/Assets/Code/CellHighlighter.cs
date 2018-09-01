using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellHighlighter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        col.gameObject.GetComponent<Cell>().CellImage.color = Color.green;
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Cell>().ChangeCellColor();
    }
}
