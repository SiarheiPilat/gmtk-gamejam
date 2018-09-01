using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Sits on each individual cell.
/// </summary>

public class Cell : MonoBehaviour {

    public enum CellState
    {
        Empty,
        Occupied,
        Closed
    }

    public CellState cellState;

    private Color emptyCellColor = Color.white, occupiedCellColor = Color.cyan, closedCellColor = Color.grey;
    [HideInInspector]
    public Image CellImage;
    
    void Start()
    {
        CellImage = GetComponent<Image>();
        SetCellState();
    }

    public void SetCellState()
    {
        switch (cellState)
        {
            case CellState.Empty:
                GetComponent<Image>().color = emptyCellColor;
                gameObject.layer = 9;
                break;
            case CellState.Occupied:
                GetComponent<Image>().color = occupiedCellColor;
                gameObject.layer = 0;
                break;
            case CellState.Closed:
                GetComponent<Image>().color = closedCellColor;
                gameObject.layer = 0;
                break;
        }
    }
}
