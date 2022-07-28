using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class Character : MonoBehaviour
    {
        private GameObject _character;
        private PlayerController _playerController;
        [SerializeField] private Material[] _CharacterSkins; //Matterial


        private byte _numberCharacter;
        private byte _numberCharacterSkin;
       

        //private int _health;
        //private float _isJumpTime;
        //public sbyte _jumpSpeed;
        //private float _drag;
        //public float SensitivityPlayer;

        public void Construct(GameObject character, byte characterNumber, byte numberCharacterSkin) 
        {
            _character = character;
            _numberCharacter = characterNumber;
            _numberCharacterSkin = numberCharacterSkin;

            AddCharacterSkin();
        }

       

        private void AddCharacterSkin()
        {
            _character.GetComponent<MeshRenderer>().material = _CharacterSkins[_numberCharacterSkin];
            //_character.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Player/Character/Materials/Content" + _numberCharacterSkin);
        }

        private void AddCharacterController()
        {
            _playerController = _character.GetComponent<PlayerController>();

        }





    }

}
