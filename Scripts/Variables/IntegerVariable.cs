using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneAgnostic
{

    [CreateAssetMenu(fileName = "Integer Variable", menuName = "SceneAgnostic/Var/Integer Variable")]
    public class IntegerVariable : ProjectEventParameter
    {

        [SerializeField] private int value;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        // User-defined conversion from IntegerVariable to integer
        public static implicit operator int(IntegerVariable i)
        {
            return i.Value;
        }

    }

}
