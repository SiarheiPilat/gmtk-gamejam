using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Sits on each individual cell. This class uses custom inspector.
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
    private Color initialColor;

    public Image CellImage;
    
    void Start()
    {
        CellImage = GetComponent<Image>();
        SetCellState(cellState);
        initialColor = CellImage.color;
    }

    public void SetCellState(CellState state)
    {
        switch (state)
        {
            case CellState.Empty:
                //Debug.Log("empty...");
                CellImage.color = emptyCellColor;
                gameObject.layer = 9;
                break;
            case CellState.Occupied:
                CellImage.color = occupiedCellColor;
                gameObject.layer = 0;
                break;
            case CellState.Closed:
                CellImage.color = closedCellColor;
                gameObject.layer = 0;
                break;
        }
    }

    public void ChangeColor(Color color)
    {
        CellImage.color = color;
    }

    internal void Repaint()
    {
        ChangeColor(initialColor);
    }

    public void ResetCell()
    {
        SetCellState(CellState.Empty);
    }
}
