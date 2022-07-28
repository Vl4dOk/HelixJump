using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class Player : MonoBehaviour
    {
        /*

                Players <----> _player <----> _characterBody
                  \/                                /\
                Camera                              ||
                                                    \/
                                              _characterSkin

        */
        private GameObject _player;
        private GameObject _character;
        private Vector3 _characterPocition;
        private GameObject _camera;

        private byte _numberCharacter;
        private byte _numberCharacterSkin;
        private byte _numberSkinMaterial;

        public void Construct(GameObject player,Vector3 characterPocition, byte numberCharacter, byte numberCharacterSkin, byte numberSkinMaterial)
        {
            _player = player;
            _numberCharacter = numberCharacter;
            _characterPocition = characterPocition;
            _numberCharacterSkin = numberCharacterSkin;
            _numberSkinMaterial = numberSkinMaterial;

            AddCharacter(_numberCharacter, _numberCharacterSkin, _numberSkinMaterial, _player.transform);
            AddCamera(_character.transform, _player.transform);
        }

        private void AddCharacter(byte numberCharacter, byte numberCharacterSkin, byte numberSkinMaterial , Transform parent)
        {
            _character = new GameObject("Character");//
           // _character = _player;

            _character.transform.position = _characterPocition;
            _character.transform.parent = parent;
            _character.AddComponent<Character>();
            _character.GetComponent<Character>().Construct(_character, _numberCharacter, _numberCharacterSkin, _numberSkinMaterial);
        }

        private void AddCamera(Transform target, Transform parent)
        {
            //_camera = new GameObject("Camers");
            _camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), _character.transform.position, Quaternion.Euler(new Vector3(40,0,0)), parent);
            _camera.transform.position = new Vector3(_character.transform.position.x, _character.transform.position.y + 5, _character.transform.position.z-9);
           
            _camera.AddComponent<CameraController>();
            _camera.GetComponent<CameraController>().Construct(target);
        }
    }
}