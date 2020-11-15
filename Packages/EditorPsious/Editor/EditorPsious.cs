using UnityEngine;
using UnityEditor;
using System.IO;

public class EditorPsious : EditorWindow
{
    string currentLine;
    string path;
    string currentFolder;

    [MenuItem("Window/EditorPsious")]
    public static void ShowWindow() 
    {
        GetWindow<EditorPsious>("EditorPsious");
    }
    private void OnGUI()
    {
        if (GUILayout.Button("CheckFiles")) 
        {
            
            string filePath = "Packages/com.javieramador.editorpsious/Resources/DirectoriesPsious.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++) 
            {
                currentLine = lines[i];
                if (currentLine[0] != '\t') 
                {
                    currentFolder = lines[i] + "/";
                    if (!Directory.Exists(path)) 
                    {
                        Debug.LogWarning("Error " + currentFolder + " no existe");
                    }
                }
                else 
                {
                    path = currentFolder + lines[i].Trim() + "/";
                    if (!Directory.Exists(path)) 
                    {
                        Debug.LogWarning("Error " + path + " no existe");
                    }
                }
            }
        }
    }
}
