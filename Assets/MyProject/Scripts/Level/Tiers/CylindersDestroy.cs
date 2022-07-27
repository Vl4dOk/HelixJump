using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylindersDestroy : MonoBehaviour
{
    private void OnTransformParentChanged()
    {        
        Destroy(gameObject, 1);
    }
}
