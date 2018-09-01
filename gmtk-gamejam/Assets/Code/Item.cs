using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerDownHandler
{
    /// <summary>
    /// The position to where the item comes back if you let go AKA "home".
    /// </summary>
    private Vector3 sittingPosition;

    /// <summary>
    /// How many cells one item occupies. This should be set manually.
    /// </summary>
    [Tooltip("How many cells one item occupies. This should be set manually.")]
    [Range(1, 10)]
    public int Size;

    public GameObject[] HostCells;

    void Start()
    {
        sittingPosition = transform.position;
        HostCells = new GameObject[Size];
    }

    /// <summary>
    /// Returns the item to its sitting position AKA "home".
    /// </summary>
    public void ReturnHome()
    {
        transform.position = sittingPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetAsLastSibling(); // this keeps the item displayed on top of other items
    }

    internal void ClearHosts()
    {
        for (int i = 0; i < HostCells.Length; i++)
        {
            if(HostCells[i] != null)
                HostCells[i].GetComponent<Cell>().ResetCell();
            HostCells[i] = null;
        }
    }
}
