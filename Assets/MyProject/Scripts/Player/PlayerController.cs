using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class PlayerController : MonoBehaviour
    {

        public float _sensitivity;
        public bool _isControlPlayer = true;
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
                transform.Rotate(0f, delta.x * _sensitivity, 0f);
            }
            _previousMousePosition = Input.mousePosition;

        }


        private void ControllerPlayerKeyboard()
        {
            if (!_isControlPlayer)
            { return; }

            if (Input.GetKey(KeyCode.A)) { transform.Rotate(0f, _sensitivity * 40, 0f); }
            if (Input.GetKey(KeyCode.D)) { transform.Rotate(0f, -_sensitivity * 40, 0f); }
            

        }

        public void Sensitivity()
        { }

    }
}