using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneAgnostic
{

    [CreateAssetMenu(fileName = "Float Variable", menuName = "SceneAgnostic/Var/Float Variable")]
    public class FloatVariable : ProjectEventParameter
    {
        [SerializeField] private float value;

        public float Value
        {
            get { return value; }
            set { this.value = value; }
        }

        // User-defined conversion from FloatVariable to float
        public static implicit operator float(FloatVariable f)
        {
            return f.Value;
        }
    }
}