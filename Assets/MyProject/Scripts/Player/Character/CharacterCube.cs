using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class CharacterCube : Character
    {

        public override void Construct(Transform parent)
        {
            _Character = Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterCube"), new Vector3(0, 5, -3), Quaternion.Euler(0, 0, 0), parent);
            _Character.name = "CharacterCube" + "";

            
            _drag = 5;
            _turnSpeed = 0.5f;
            _jumpSpeed = 30;
            _health = 1;



            _rb_Character = _Character.GetComponent<Rigidbody>();
            _rb_Character.drag = _drag;

        }



    }
}