using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SceneAgnostic {

    [CustomEditor(typeof(ProjectEvent))]
    public class ProjectEventEditor : Editor {


        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            ProjectEvent e = target as ProjectEvent;
            if (GUILayout.Button("Raise"))
            {
                e.Raise();
            }

        }
    }
}