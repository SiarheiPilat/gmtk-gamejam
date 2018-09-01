using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {

    public enum CellState
    {
        Empty,
        Occupied,
        Closed
    }

    public CellState cellState;

    private Color emptyCellColor = Color.white, occupiedCellColor = Color.cyan, closedCellColor = Color.grey;

    public Image CellImage;
    public Color CellColor;
    
    void Start()
    {
        CellImage = GetComponent<Image>();
        CellColor = CellImage.color;
    }

    public void ChangeCellColor()
    {
        switch (cellState)
        {
            case CellState.Empty:
                GetComponent<Image>().color = emptyCellColor;
                break;
            case CellState.Occupied:
                GetComponent<Image>().color = occupiedCellColor;
                break;
            case CellState.Closed:
                GetComponent<Image>().color = closedCellColor;
                break;
        }
    }
}
