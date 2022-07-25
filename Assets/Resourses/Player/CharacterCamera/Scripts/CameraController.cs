using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject _camera;
    private float _heightDifference = 2;
    private Transform _transform_target;

    private float speed;



  /*  public CameraController(Transform parent)
    {
        _camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), new Vector3(0, 10, -9), Quaternion.Euler(new Vector3(40, 0, 0)), parent);
        _camera.name = "CharacterCamera";
        _transform_target = transform.parent.Find("CharacterSphere");
        _heightDifference = 2;
    }
  */
    public void ConstrCameraController(Transform target,Transform parent)
    {
        _camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), new Vector3(0, 10, -9), Quaternion.Euler(new Vector3(40, 0, 0)), parent);
        _camera.name = "CharacterCamera";
        _transform_target = target;
        _heightDifference = 2;
    }



    private void Start()
    {
        _transform_target = transform.parent.Find("CharacterSphere");
    }


    private void FixedUpdate()
    {        
        if (_transform_target.position.y + _heightDifference < transform.position.y)
        {            
            speed = (_transform_target.position.y + _heightDifference) - transform.position.y;
        }

        if (_transform_target.position.y + _heightDifference < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            speed += Time.deltaTime;
}   }   }