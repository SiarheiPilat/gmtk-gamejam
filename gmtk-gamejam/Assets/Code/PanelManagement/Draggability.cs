using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggability : MonoBehaviour, IDragHandler, IEndDragHandler, 
    IBeginDragHandler
{

    public void OnBeginDrag(PointerEventData eventData)
    {
        Manager.SelectedItem = gameObject.GetComponent<Item>();
        Manager.SelectedItem.gameObject.AddComponent<CellHighlighter>();
        ResetHostCells();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(Manager.SelectedItem.gameObject.GetComponent<CellHighlighter>());

        // if manager allows installation, install it right away
        if (Manager.CanInstall == true)
        {
            SnapRightIn();

        }
        // if not, return it home
        else
        {
            Manager.SelectedItem.ReturnHome();
        }
    }

    /// <summary>
    /// Places the item in the middle of its occupying cells and resets manager tracking.
    /// </summary>
    private void SnapRightIn()
    {
        for (int i = 0; i < Manager.TriggeredCells.Count; i++)
        {
            Manager.SelectedItem.HostCells[i] = Manager.TriggeredCells[i]; // setting host cells
            Manager.TriggeredCells[i].GetComponent<Cell>().SetCellState(Cell.CellState.Occupied);
            //SOMETHING SETS EM TO 'EMPTY' RIGHT AFTER!.. but it works anyway.
            //Debug.Log(Manager.TriggeredCells[i].GetComponent<Cell>().cellState);
        }
        Manager.SelectedItem.GetComponent<RectTransform>().anchoredPosition = Utils.MidPoint(Manager.SelectedItem.HostCells);
        Manager.Reset();
    }

    void ResetHostCells()
    {
        if (Manager.SelectedItem)
        {
            //Debug.Log("reset");
            Manager.SelectedItem.ClearHosts();
        }

    }
}
