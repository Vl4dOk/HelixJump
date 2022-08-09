using UnityEngine;

public class Tier : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;


    private void Start()
    {
        if (_audioSource == null)
        {   _audioSource = GetComponent<AudioSource>();}
    }


    private void OnTriggerEnter()
    {
        _audioSource.Play();
        gameObject.transform.DetachChildren();
        LevelBuilder LB = gameObject.transform.GetComponentInParent<LevelBuilder>();
        LB.Continue();
    }

    private void OnTriggerExit(Collider other)
    {  Destroy(gameObject);}





}
