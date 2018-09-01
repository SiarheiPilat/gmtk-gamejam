using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cell))]
public class CellInspector : Editor {

    //TODO:
    // 1 - multi object editing
    // 2 - paint tool

    public override void OnInspectorGUI()
    {

        Cell myTarget = (Cell)target;

        myTarget.SetCellState();

        myTarget.cellState = (Cell.CellState)EditorGUILayout.EnumPopup("Cell state:", myTarget.cellState);

        if (GUI.changed)
        {
            myTarget.SetCellState();
        }

    }
}
