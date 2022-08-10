using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class Character : MonoBehaviour
    {
        private GameObject _character;
        private MyCharacterController _playerController;
        [SerializeField] private Material[] _CharacterSkins; //Matterial


        private int _numberCharacter;
        private int _numberCharacterSkin;
       

        //private int _health;
        //private float _isJumpTime;
        //public sbyte _jumpSpeed;
        //private float _drag;
        //public float SensitivityPlayer;

        public void Construct(GameObject character, int characterNumber, int numberCharacterSkin) 
        {
            _character = character;
            _numberCharacter = characterNumber;
            _numberCharacterSkin = numberCharacterSkin;

            AddCharacterSkin();
        }

       

        private void AddCharacterSkin()
        {
            GetComponent<MeshRenderer>().material = _CharacterSkins[_numberCharacterSkin];
        }

        private void AddCharacterController()
        {
            _playerController = _character.GetComponent<MyCharacterController>();

        }





    }

}
