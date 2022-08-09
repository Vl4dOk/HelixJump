using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;

public class Segment4 : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        if (_rigidbody == null)
        { _rigidbody = GetComponent<Rigidbody>(); }
        if (_audioSource == null)
        { _audioSource = GetComponent<AudioSource>(); }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out CharacterCharacteristics Character))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);

            if (dot >= 0.5) { Character.Jump(); }

            _audioSource.Play();
            Destroy(gameObject, 0.15f);
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
