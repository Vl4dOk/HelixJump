using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public abstract class Character : MonoBehaviour
    {
        public GameObject _Character;
        protected Rigidbody _rb_Character;
        protected float _drag;
        protected float _turnSpeed;
        protected sbyte _jumpSpeed;
        protected sbyte _health;
        protected float _isJumpTime; //bool


       

        protected void FixedUpdate()
        {
            if (_isJumpTime > 0)
            { _isJumpTime -= Time.deltaTime; }
        }

        public abstract void Construct(Transform parent);


        public void Jump(byte speedCompensation)
        {
            if (_isJumpTime <= 0)
            {
                _rb_Character.AddForce(new Vector3(0, _jumpSpeed + speedCompensation, 0), ForceMode.Impulse);
                _isJumpTime += 0.2f;
            }
        }


        public void RecessiveDamage(sbyte damage)
        {
            _health -= damage;

            if (_health <= 0)
            {   
                _rb_Character.isKinematic = true;
                GetComponentInParent<PlayerController>()._isControlPlayer = false;
                MenuManager.MainMenuManager.CallingMenu_DefeatScreen();
            }
        }


    }
}
