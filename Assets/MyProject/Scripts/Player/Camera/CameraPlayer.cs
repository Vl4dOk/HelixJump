using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Players
{
    public class CameraPlayer : MonoBehaviour
    {
        private GameObject _Camera;
        private CameraController _cameraController;



        public void Construct(Transform target ,Transform parent)
        {
            _Camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), new Vector3(0, 5, -9), Quaternion.Euler(new Vector3(40, 0, 0)), parent);
            _Camera.name = "CharacterCamera" + "";

            _Camera.AddComponent<CameraController>();
            _cameraController = _Camera.GetComponent<CameraController>();
            _cameraController._targetTransform = target;
        }


    }
}