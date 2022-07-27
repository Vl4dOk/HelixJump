using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class Character : MonoBehaviour
    {
        private GameObject _character;
        private GameObject _CharacterBody; //Collaider
        private GameObject _CharacterSkin; //Matterial or other

        private byte _numberCharacter;
        private byte _numberCharacterSkin;
        private byte _numberSkinMaterial;

        //private int _health;
        //private float _isJumpTime;
        //public sbyte _jumpSpeed;
        //private float _drag;
        //public float SensitivityPlayer;



        public void Construct(GameObject character, byte characterNumber, byte numberCharacterSkin, byte numberSkinMaterial) 
        {
            _character = character;
            _numberCharacter = characterNumber;
            _numberCharacterSkin = numberCharacterSkin;
            _numberSkinMaterial = numberSkinMaterial;

            AddCharacterBody();
            AddCharacterSkin();
        }

        private void AddCharacterBody()
        {
            //_CharacterBody = new GameObject("CharacterBody");
            _CharacterBody = _character;//


            _CharacterBody.transform.parent = _character.transform;
            _CharacterBody.AddComponent<CharacterBody>();
            _CharacterBody.GetComponent<CharacterBody>().Construct(_CharacterBody, _numberCharacter);
        }

        private void AddCharacterSkin()
        {
            //_CharacterSkin = new GameObject("CharacterSkin");
            _CharacterSkin = _character;//


            _CharacterSkin.transform.parent = _character.transform;
            _CharacterSkin.AddComponent<CharacterSkin>();
            _CharacterSkin.GetComponent<CharacterSkin>().Construct(_CharacterSkin, _numberCharacterSkin, _numberSkinMaterial);
        }


    }

}
