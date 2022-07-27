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
        private GameObject _camera;

        private byte _numberCharacter;
        private byte _numberCharacterSkin;
        private byte _numberSkinMaterial;

        public void Construct(GameObject player, byte numberCharacter, byte numberCharacterSkin, byte numberSkinMaterial)
        {
            _player = player;
            _numberCharacter = numberCharacter;
            _numberCharacterSkin = numberCharacterSkin;
            _numberSkinMaterial = numberSkinMaterial;

            AddCharacter(_numberCharacter, _numberCharacterSkin, _numberSkinMaterial, _player.transform);
            AddCamera(_character.transform, _player.transform);
        }

        private void AddCharacter(byte numberCharacter, byte numberCharacterSkin, byte numberSkinMaterial , Transform parent)
        {
            _character = new GameObject("Character");//
           // _character = _player;

            _character.transform.position = _player.transform.position;
            _character.transform.parent = parent;
            _character.AddComponent<Character>();
            _character.GetComponent<Character>().Construct(_character, _numberCharacter, _numberCharacterSkin, _numberSkinMaterial);
        }

        private void AddCamera(Transform target, Transform parent)
        {
            //_camera = new GameObject("Camers");
            _camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), new Vector3(0,5,-9),Quaternion.Euler(new Vector3(40,0,0)), parent);
            //_camera.transform.position = _player.transform.position;
            //_camera.transform.parent = parent;
            _camera.AddComponent<CameraController>();
            _camera.GetComponent<CameraController>().Construct(target);
        }
    }
}