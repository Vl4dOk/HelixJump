using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoins : MonoBehaviour
{
    private void OnTransformParentChanged()
    {
        Destroy(gameObject, 2);
    }
}
