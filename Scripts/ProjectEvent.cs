using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneAgnostic
{


    [CreateAssetMenu(fileName = "Project Event", menuName = "SceneAgnostic/Project Event")]
    public class ProjectEvent : ScriptableObject
    {

        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<ProjectEventListener> eventListeners =
            new List<ProjectEventListener>();


        public void Raise()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(ProjectEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(ProjectEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);

        }
    }
}