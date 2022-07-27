using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Segment1 : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private byte _speedCompensation = 0;




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<CharacterCube>())
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5)
            { collision.collider.gameObject.GetComponent<CharacterCube>().Jump(_speedCompensation); }
        }
    }


    private void OnTransformParentChanged()
    {
        _rigidbody.isKinematic = false;
        _rigidbody.AddRelativeForce(new Vector3(0, 0, 7), ForceMode.Impulse);
        Destroy(gameObject, 2);
    }

}
