using UnityEngine;

public class SoundsSegments : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character Character))
        {
            if (!_sound.isPlaying)
            {
                _sound.Play();
                //_sound.PlayOneShot(_sound.clip);
            }
        }
    }
}
