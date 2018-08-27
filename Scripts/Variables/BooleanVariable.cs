using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneAgnostic
{

    [CreateAssetMenu(fileName = "Boolean Variable", menuName = "SceneAgnostic/Var/Boolean Variable")]
    public class BooleanVariable : ProjectEventParameter
    {

        [SerializeField] private bool value;

        public bool Value
        {
            get { return value; }
            set { this.value = value; }
        }

        // User-defined conversion from BooleanVariable to bool
        public static implicit operator bool(BooleanVariable b)
        {
            return b.Value;
        }

    }

}
