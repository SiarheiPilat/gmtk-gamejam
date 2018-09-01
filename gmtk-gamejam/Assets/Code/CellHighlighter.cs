using UnityEngine;


/// <summary>
/// Responsible for highlighting cells. Note that even though it is a 2D-game, triggers have to be detected with 3D colliders.
/// This script should be sitting on the item.
/// </summary>

public class CellHighlighter : MonoBehaviour {

    private Item item;

    void Start()
    {
        item = GetComponent<Item>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (item.itemState == Item.ItemState.Unplugged)
        {
            Manager.HighlightedCellsAmount++;
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.layer == 10)
        {
            Manager.ItemCanBeInstalled = false;
        }

        if (item.itemState == Item.ItemState.Unplugged)
        {
            other.gameObject.GetComponent<Cell>().CellImage.color = Color.green;

            if (!Manager.HighlightedGameobjects.Contains(other.gameObject))
            {
                Manager.HighlightedGameobjects.Add(other.gameObject);
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            Manager.ItemCanBeInstalled = true;
        }

        other.gameObject.GetComponent<Cell>().cellState = Cell.CellState.Empty;
        other.gameObject.GetComponent<Cell>().SetCellState();

        if (Manager.HighlightedGameobjects.Contains(other.gameObject))
        {
            Manager.HighlightedGameobjects.Remove(other.gameObject);
        }

        if (Manager.HighlightedCellsAmount <= 0)
        {
            Manager.HighlightedCellsAmount = 0;
        }
        else Manager.HighlightedCellsAmount--;


    }
}
