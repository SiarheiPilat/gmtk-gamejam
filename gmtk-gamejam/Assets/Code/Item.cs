using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    /// <summary>
    /// The position to where the item comes back if you let go.
    /// </summary>
    private Vector3 sittingPosition;

    /// <summary>
    /// How many cells one item occupies. This should be set manually.
    /// </summary>
    [Tooltip("How many cells one item occupies. This should be set manually.")]
    [Range(1, 10)]
    public int Size;

    public enum ItemState
    {
        Plugged,
        Unplugged
    }


    public ItemState itemState;

    void Start()
    {
        sittingPosition = transform.position;
        itemState = ItemState.Unplugged;
    }

    /// <summary>
    /// Places the item into the slot.
    /// </summary>
    public void PlugItem()
    {
        //Manager.HighlightedCellsAmount = 0; //reset cells count
        OccupyCells(); //mark sells occupied
        SnapRightIn(); //snap item into slots
        Manager.Reset();
    }

    private void SnapRightIn()
    {
        
    }

    //currently broken
    private void OccupyCells()
    {
        for (int i = 0; i < Manager.HighlightedGameobjects.Count - 1; i++)
        {
            Manager.HighlightedGameobjects[i].GetComponent<Cell>().cellState = Cell.CellState.Occupied;
            Manager.HighlightedGameobjects[i].GetComponent<Cell>().SetCellState();
        }
    }

    /// <summary>
    /// Returns the item to its sitting position AKA "home".
    /// </summary>
    public void ReturnItemHome()
    {
        transform.position = sittingPosition;
        itemState = ItemState.Unplugged;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetAsLastSibling(); // this keeps the item displayed on top of other items
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
