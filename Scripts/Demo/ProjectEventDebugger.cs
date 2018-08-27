using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SceneAgnostic
{

    public class ProjectEventDebugger : MonoBehaviour
    {

        public void DebugEvent(ProjectEventParameter p)
        {
            if(p is StringVariable)
            {
                var s = p as StringVariable;
                Debug.Log(s.Value);
            }

            if(p is ListOfStringVariables)
            {
                var l = p as ListOfStringVariables;
                foreach (var e in l.list)
                {
                    Debug.Log(e);
                }
            }
        }

        public void DebugEvent()
        {
            Debug.Log("event without params");
        }
    }
}