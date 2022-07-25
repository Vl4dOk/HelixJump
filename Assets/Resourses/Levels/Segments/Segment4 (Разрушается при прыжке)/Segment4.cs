using UnityEngine;

public class Segment4 : MonoBehaviour
{
    private float _speedCharacter = 15;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5)
            { Character.JumpCharacter(_speedCharacter); }

            Destroy(gameObject,0.15f);
        }

    }
}