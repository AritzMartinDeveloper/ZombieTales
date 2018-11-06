using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class MenuItems
{

    [MenuItem("Tools/LevelCreator/New Level Scene")]
    private static void NewLevel()
    {
        EditorUtils.NewLevel();
    }
    
}
