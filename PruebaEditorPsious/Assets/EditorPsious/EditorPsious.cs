using UnityEngine;
using UnityEditor;

public class EditorPsious : EditorWindow
{
    [MenuItem("Window/EditorPsious")]
    public static void ShowWindow() 
    {
        EditorWindow.GetWindow<EditorPsious>("EditorPsious");
    }
    private void OnGUI()
    {
        if (GUILayout.Button("CheckFiles")) 
        {
            
        }
    }
}
