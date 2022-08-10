using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class CharacterCharacteristics : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;

        [SerializeField] private int _jumpSpeed;
        [SerializeField] private sbyte health;

        private bool _isJump;




        public void Jump(float modSpeed = 1)
        {
            if (!_isJump)
            {
                rb.AddForce(new Vector3(0, _jumpSpeed * modSpeed, 0), ForceMode.Impulse);
                _isJump = true;
            }
        }

        public void TakingDamage(sbyte Damage)
        {
            health -= Damage;
            if (health <= 0)
            {               
                GetComponent<MyCharacterController>()._isControlPlayer = false;
                rb.isKinematic = true;
                GlobalEventManager.Event_PlayerDied?.Invoke();
                GetComponent<ShaderGraphContent1>()._isActive = true;
            }

        }





        private void OnCollisionExit(Collision collision)
        {
            _isJump = false;
        }

    }
}