using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class CharacterCharacteristics : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;

        [SerializeField] private byte _jumpSpeed;
        [SerializeField] private sbyte health;

        private bool _isJump;




        public void Jump()
        {
            if (!_isJump)
            {
                rb.AddForce(new Vector3(0, _jumpSpeed, 0), ForceMode.Impulse);
                _isJump = true;
            }
        }

        public void TakingDamage(sbyte Damage)
        {
            health -= Damage;
            if (health <= 0)
            {
                GetComponent<PlayerController>()._isControlPlayer = false;
                rb.isKinematic = true;
                MenuManager.MainMenuManager.CallingMenu_DefeatScreen();
            }

        }





        private void OnCollisionExit(Collision collision)
        {
            _isJump = false;
        }

    }
}