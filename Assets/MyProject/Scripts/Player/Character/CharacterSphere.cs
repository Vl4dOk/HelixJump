using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class CharacterSphere : Character
    {
        public override void Construct(Transform parent)
        {
            _Character = Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterSphere"), new Vector3(0, 5, -3), Quaternion.Euler(0, 0, 0), parent);
            _Character.name = "CharacterSphere" + "";


            _drag = 0;
            _turnSpeed = 1;
            _jumpSpeed = 15;
            _health = 1;                    
        }



    }
}