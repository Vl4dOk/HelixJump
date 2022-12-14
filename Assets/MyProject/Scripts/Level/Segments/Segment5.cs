using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;

public class Segment5 : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private ParticleSystem _particleSystem;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out CharacterCharacteristics Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5)
            {
                Character.Jump(0.65f);
                
                if (_particleSystem == null)
                { _particleSystem = GetComponent<ParticleSystem>(); }
                _particleSystem.Play();
            }
        }
    }


    private void OnTransformParentChanged()//Can be transferred to animation
    {
        _rigidbody.isKinematic = false;
        _rigidbody.AddRelativeForce(new Vector3(0, Random.Range(0, 5), Random.Range(7, 10)), ForceMode.Impulse);
        _rigidbody.AddRelativeTorque(new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10)), ForceMode.Impulse);
        Destroy(gameObject, 2);
    }
}
