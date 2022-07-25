using UnityEngine;

public class Segment1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5)
            { Character.JumpCharacter(Character._speedJump); }
        }
    }
}

