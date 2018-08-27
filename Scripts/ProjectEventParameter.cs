using UnityEngine;

namespace SceneAgnostic
{

    public class ProjectEventParameter : ScriptableObject
    {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

    }
}