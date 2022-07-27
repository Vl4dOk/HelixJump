using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Segment2 : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5)
            { Character.RecessiveDamage(1); }
        }
    }


    private void OnTransformParentChanged()
    {
        _rigidbody.isKinematic = false;
        _rigidbody.AddRelativeForce(new Vector3(0, 0, 7), ForceMode.Impulse);
        Destroy(gameObject, 2);
    }
}
