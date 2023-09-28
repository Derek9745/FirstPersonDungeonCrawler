using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DebugEditor : EditorWindow
{
    [MenuItem("Game/DebugEditor")]
    private static void OpenWindow()
    {
        var window = GetWindow<DebugEditor>();
        window._trackedResources = Extensions.GetAllInstances<ScriptableObject>().ToList();
        window._trackedGameObjects = Extensions.GetAllObjectsOnlyInScene().ToList();
    }
    public List<GameObject> _trackedGameObjects;
    public List<ScriptableObject> _trackedResources;
    int columnWidth = 100;
    bool showingParticleSystems;
    bool showEnemies;
    bool showBullets;
    bool showItems;

    Vector2 scrollPos;
    private void OnGUI()
    {
        EditorGUILayout.LabelField("Column Width");
        columnWidth = EditorGUILayout.IntField(columnWidth);
        DrawButtons();
        
    }
    
    static void DrawButtons()
    {
        GUILayout.BeginHorizontal();
        if(GUILayout.Button("Tick All"))
        {
            
        }

        GUILayout.EndHorizontal();
    }
   










}


