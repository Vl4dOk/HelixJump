using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private float X = 5,Y = 5,Z = 5;

    private float _angle = 1;
    private Quaternion _quaternion;


    private void Start()
    {
        if (_audioSource == null) { _audioSource = GetComponent<AudioSource>(); }

        _quaternion = transform.localRotation;
    }

    private void FixedUpdate()
    {
        Quaternion RotationX = Quaternion.AngleAxis(_angle, new Vector3(X, 0, 0));
        Quaternion RotationY = Quaternion.AngleAxis(_angle, new Vector3(0, Y, 0));
        Quaternion RotationZ = Quaternion.AngleAxis(_angle, new Vector3(0, 0, Z));
        transform.localRotation = _quaternion * RotationX * RotationY * RotationZ;
        _angle++;
        if (_angle == 360) { _angle = 0; }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        _audioSource.Play();
        Destroy(gameObject,0.1f);
    }
}
