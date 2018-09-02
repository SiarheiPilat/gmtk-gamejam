using System;
using UnityEngine;


/// <summary>
/// Responsible for highlighting cells and tracking how many cells are hovered over. 
/// Note that even though it is a 2D-game, triggers have to be detected with 3D colliders.
/// This script should be sitting on the item.
/// </summary>

public class CellHighlighter : MonoBehaviour {

    // HIGHLIGHTER REMOVED
    //void OnTriggerStay(Collider other)
    //{
    //    // if touching another item, can't install the item - no need to calculace the size
    //    if(other.gameObject.layer == 10)
    //    {
    //        Manager.CanInstall = false;
    //    }
    //    else
    //    {
    //        // if we are hovering over the correct layers and have selected an item, we can try install it
    //        if(other.gameObject.layer == 9 && Manager.SelectedItem)
    //        {
    //            AddTriggeredCell(other.gameObject);
    //            // if size fits, allow for installation and highlight hosting cells
    //            if (Manager.TriggeredCells.Count == Manager.SelectedItem.Size)
    //            {
    //                Manager.CanInstall = true;
    //                HighlightSelectable();
    //            }
    //            // if the size is wrong, deny installation
    //            else
    //            {
    //                Manager.CanInstall = false;
    //                other.gameObject.GetComponent<Cell>().Repaint();
    //            }
    //        }
    //    }
    //}

    ///// <summary>
    ///// Highlight cells if and where it is possible to place the item.
    ///// </summary>
    //private void HighlightSelectable()
    //{
    //    for (int i = 0; i < Manager.TriggeredCells.Count; i++)
    //    {
    //        Manager.TriggeredCells[i].GetComponent<Cell>().ChangeColor(Color.green);
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if(other.gameObject.layer == 9)
    //    {
    //        RemoveTriggeredCell(other.gameObject);
    //        other.gameObject.GetComponent<Cell>().Repaint();
    //    }
    //}

    //void AddTriggeredCell(GameObject cell)
    //{
    //    if (!Manager.TriggeredCells.Contains(cell))
    //    {
    //        Manager.TriggeredCells.Add(cell);
    //    }
    //}

    //void RemoveTriggeredCell(GameObject cell)
    //{
    //    if (Manager.TriggeredCells.Contains(cell))
    //    {
    //        Manager.TriggeredCells.Remove(cell);
    //    }
    //}
}
