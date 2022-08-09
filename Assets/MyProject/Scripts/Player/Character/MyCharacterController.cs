using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Players
{
    public class MyCharacterController : MonoBehaviour
    {

        public float _sensitivity = 0.1f;
        [HideInInspector] public bool _isControlPlayer = true;
        public Vector3 _point = new Vector3(0, 0, 0);
        private Vector3 _previousMousePosition;

      

        private void Update()
        {
            ControllerPlayerMouse();
        }

        private void FixedUpdate()
        {
            ControllerPlayerKeyboard();
        }

        private void ControllerPlayerMouse()
        {
            if (!_isControlPlayer)
            { return; }

            if (Input.GetMouseButton(0))
            {
                Vector3 delta = Input.mousePosition - _previousMousePosition;                
                transform.RotateAround(_point, new Vector3(0f, delta.x, 0f), _sensitivity);

                //transform.Rotate(0f, delta.x * _sensitivity, 0f);
            }
            _previousMousePosition = Input.mousePosition;
        }

        private void ControllerPlayerKeyboard()
        {
            if (!_isControlPlayer)
            { return; }
            
            if (Input.GetKey(KeyCode.A)) { transform.RotateAround(_point, new Vector3(0f, 1, 0f), _sensitivity + 1); }
            if (Input.GetKey(KeyCode.D)) { transform.RotateAround(_point, new Vector3(0f, -1, 0f), _sensitivity + 1); }
            
            //if (Input.GetKey(KeyCode.A)) { transform.Rotate(0f, _sensitivity * 40, 0f); }
            //if (Input.GetKey(KeyCode.D)) { transform.Rotate(0f, -_sensitivity * 40, 0f); }
        }
    }
}