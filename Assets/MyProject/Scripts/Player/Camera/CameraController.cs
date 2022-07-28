using UnityEngine;

namespace Players
{
    public class CameraController : MonoBehaviour
    {
        public Transform _targetTransform;
        private float _heightDifference;
        private float _speed;
        private float _sensitivity;
        [HideInInspector] public bool _isControlCamera = true;
        private Vector3 _point;
        private Vector3 _previousMousePosition;


        public void Construct(GameObject target, float heightDifference = 5)
        {
            _targetTransform = target.transform;
            _heightDifference = heightDifference;
            this._sensitivity = target.GetComponent<PlayerController>()._sensitivity;
            this._point = target.GetComponent<PlayerController>()._point;
        }

        private void Update()
        {
            MouseController();            
        }

        private void FixedUpdate()
        {
            KeyboardController();
        }





        private void MouseController()
        {
            if (!_isControlCamera)
            { return; }

            if (Input.GetMouseButton(0))
            {
                Vector3 delta = Input.mousePosition - _previousMousePosition;
                transform.RotateAround(_point, new Vector3(0f, delta.x, 0f), _sensitivity);
            }
            _previousMousePosition = Input.mousePosition;

            if (_targetTransform.position.y + _heightDifference < gameObject.transform.position.y)
            {
                _speed = (_targetTransform.position.y + _heightDifference) - gameObject.transform.position.y;
            }
            if (_targetTransform.position.y + _heightDifference < gameObject.transform.position.y)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + _speed, gameObject.transform.position.z);
                _speed += Time.deltaTime;
        }   }

        private void KeyboardController()
        {
            if (!_isControlCamera)
            { return; }

            if (Input.GetKey(KeyCode.A)) { transform.RotateAround(_point, new Vector3(0f, 1, 0f), _sensitivity + 1); }
            if (Input.GetKey(KeyCode.D)) { transform.RotateAround(_point, new Vector3(0f, -1, 0f), _sensitivity + 1); }
        }
    }
 
}