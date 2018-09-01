using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Item))]
public class ItemInspector : Editor {

    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox("Remember to manually set number of cells that this item occupies!", MessageType.Warning);
        DrawDefaultInspector();
    }

}
