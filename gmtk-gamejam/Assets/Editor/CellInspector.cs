using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof(Cell))]
public class CellInspector : Editor {

    //TODO:
    // 1 - multi object editing
    // 2 - paint tool

    Cell myTarget;

    public override void OnInspectorGUI()
    {

        //CELL REMOVED
        //myTarget = (Cell)target;

        //myTarget.CellImage = myTarget.gameObject.GetComponent<Image>();

        //myTarget.cellState = (Cell.CellState)EditorGUILayout.EnumPopup("Set state to:", myTarget.cellState);

        //if (GUI.changed)
        //{
        //    myTarget.SetCellState(myTarget.cellState);
        //}

        DrawDefaultInspector();
    }
}
