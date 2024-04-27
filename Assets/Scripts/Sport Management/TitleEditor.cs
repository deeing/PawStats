using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(Title))]
public class TitleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default inspector
        DrawDefaultInspector();

        // Get the target object
        Title title = (Title)target;

        // Ensure there is a sport assigned
        if (title.sport != null && title.sport.sportClasses != null)
        {
            // Heading
            EditorGUILayout.LabelField("Select Sport Classes:", EditorStyles.boldLabel);

            // Iterate over all possible sport classes
            for (int i = 0; i < title.sport.sportClasses.Count; i++)
            {
                var sportClass = title.sport.sportClasses[i];
                bool isSelected = title.sportClasses.Contains(sportClass);

                // Toggle for each sport class
                bool toggle = EditorGUILayout.Toggle(sportClass.name, isSelected);
                if (toggle != isSelected)
                {
                    if (toggle)
                    {
                        title.sportClasses.Add(sportClass); // Add if toggled on
                    }
                    else
                    {
                        title.sportClasses.Remove(sportClass); // Remove if toggled off
                    }
                    EditorUtility.SetDirty(title);
                }
            }
        }
        else
        {
            EditorGUILayout.HelpBox("No Sport assigned or Sport has no Sport Classes. Please assign a Sport with Sport Classes to this Title.", MessageType.Warning);
        }
    }
}