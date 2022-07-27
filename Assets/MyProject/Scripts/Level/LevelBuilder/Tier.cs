using UnityEngine;

public class Tier : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        gameObject.transform.DetachChildren();
        LevelBuilder LB = gameObject.transform.GetComponentInParent<LevelBuilder>();
        LB.Continue();
    }


    private void OnTriggerExit(Collider other)
    {      
        Destroy(gameObject);
    }





}
