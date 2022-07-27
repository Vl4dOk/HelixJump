using UnityEngine;

namespace Players
{
    public class CameraController : MonoBehaviour
    {
        public Transform _targetTransform;
        private float _heightDifference;
        private float _speed;

       

        public void Construct(Transform target,float heightDifference = 4)
        {
            _targetTransform = target;
            _heightDifference = heightDifference;
        }


        private void FixedUpdate()
        {
            if (_targetTransform.position.y + _heightDifference < gameObject.transform.position.y)
            {
                _speed = (_targetTransform.position.y + _heightDifference) - gameObject.transform.position.y;
            }

            if (_targetTransform.position.y + _heightDifference < gameObject.transform.position.y)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + _speed, gameObject.transform.position.z);
                _speed += Time.deltaTime;
            }
        }
    }
}