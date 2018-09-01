using UnityEngine;
using UnityEngine.EventSystems;

public class Draggability : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{

    private Item item;

    void Start()
    {
        item = GetComponent<Item>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Manager.Reset();
        item.itemState = Item.ItemState.Unplugged;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Manager.HighlightedCellsAmount == item.Size && Manager.ItemCanBeInstalled)
        {
            item.PlugItem();
            item.itemState = Item.ItemState.Plugged;
        }
        else
        {
            item.ReturnItemHome();
        }
        Manager.Reset();
    }

}
