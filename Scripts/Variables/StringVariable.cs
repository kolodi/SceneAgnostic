using UnityEngine;

namespace SceneAgnostic
{

    [CreateAssetMenu(fileName ="String Variable", menuName = "SceneAgnostic/Var/String Variable")]
    public class StringVariable : ProjectEventParameter
    {
        
        [SerializeField] private string value = "";

        public string Value
        {
            get { return value; }
            set { this.value = value;  }
        }

        // User-defined conversion from StringVariable to string
        public static implicit operator string(StringVariable s)
        {
            return s.Value;
        }
    }
}