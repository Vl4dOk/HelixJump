using UnityEngine;

public class Coins : MonoBehaviour
{
    private float X = 5,Y = 5,Z = 5;

    private float _angle = 1;
    private Quaternion _quaternion;


    private void Start()
    {        
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
        GameManager.MainGameManeger.AddScore(1);
        Destroy(gameObject);
    }
}
