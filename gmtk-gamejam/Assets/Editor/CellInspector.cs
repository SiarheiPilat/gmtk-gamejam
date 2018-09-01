using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cell))]
[CanEditMultipleObjects]
public class CellInspector : Editor {

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        Cell myTarget = (Cell)target;

        myTarget.cellState = (Cell.CellState)EditorGUILayout.EnumPopup("Cell state:", myTarget.cellState);

        if (GUI.changed)
        {
            myTarget.ChangeCellColor();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
