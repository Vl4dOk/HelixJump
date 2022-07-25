using UnityEngine;

public class Segment2 : MonoBehaviour
{
    private float _speedCharacter = 15;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            Character.JumpCharacter(_speedCharacter);
            Character.DamageCharacter(1);
        }
    }
       

    
}
