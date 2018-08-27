using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneAgnostic
{

    [CreateAssetMenu(fileName = "Strings List", menuName = "SceneAgnostic/Var/String List")]
    public class ListOfStringVariables : ProjectEventParameter
    {

        public List<string> list;

        // User-defined conversion from ListOfStringVariables to List<string>
        public static implicit operator List<string>(ListOfStringVariables listOfStringVariables)
        {
            return listOfStringVariables.list;
        }

    }
}