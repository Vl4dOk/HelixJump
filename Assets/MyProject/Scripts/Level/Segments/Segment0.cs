using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;

public class Segment0 : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        if (_audioSource == null)
        { _audioSource = GetComponent<AudioSource>(); }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character character))
        {
            character.GetComponent<Rigidbody>().isKinematic = true;
            GlobalEventManager.Event_PlayerOnFinish?.Invoke();
            GetComponent<ParticleSystem>().Play();
            _audioSource.Play();
        }
    }

   


}
