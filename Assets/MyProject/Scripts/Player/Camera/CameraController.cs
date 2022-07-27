using UnityEngine;

namespace Player
{
    public class CameraController : MonoBehaviour
    {
        public Transform _targetTransform;
        private float heightDifference = 4;
        private float speed;

       

        public void Construct(Transform target)
        {
            _targetTransform = target;
        }


        private void FixedUpdate()
        {
            if (_targetTransform.position.y + heightDifference < gameObject.transform.position.y)
            {
                speed = (_targetTransform.position.y + heightDifference) - gameObject.transform.position.y;
            }

            if (_targetTransform.position.y + heightDifference < gameObject.transform.position.y)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed, gameObject.transform.position.z);
                speed += Time.deltaTime;
            }
        }
    }
}