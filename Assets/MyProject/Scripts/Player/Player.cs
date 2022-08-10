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

        private int _numberCharacter;
        private int _numberCharacterSkin;


        public void Construct(GameObject player, Vector3 characterPocition, int numberCharacter, int numberCharacterSkin)
        {
            _player = player;
            _numberCharacter = numberCharacter;
            _characterPocition = characterPocition;
            _numberCharacterSkin = numberCharacterSkin;


            AddCharacter(_numberCharacter, _numberCharacterSkin, _player.transform);
            AddCamera(_character, _player.transform);
        }

        private void AddCharacter(int numberCharacter, int numberCharacterSkin , Transform parent)
        {

            _character = numberCharacter == 0 ?  Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterSphere"), _player.transform) :
                         numberCharacter == 1 ?  Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterCube"), _player.transform) :
                         numberCharacter == 2 ?  Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterCylinder"), _player.transform) :
                      /* numberCharacter == 3 */ Instantiate(Resources.Load<GameObject>("Player/Character/Prefabs/CharacterCapsule"), _player.transform);
            _character.transform.position = _characterPocition;
            _character.GetComponent<Character>().Construct(_character, _numberCharacter, _numberCharacterSkin);
           
        }

        private void AddCamera(GameObject target, Transform parent)
        {
            //_camera = new GameObject("Camers");
            _camera = Instantiate(Resources.Load<GameObject>("Player/CharacterCamera/Prefabs/Camera"), _character.transform.position, Quaternion.Euler(new Vector3(40,0,0)), parent);
            _camera.transform.position = new Vector3(_character.transform.position.x, _character.transform.position.y + 5, _character.transform.position.z-6);
           
            _camera.AddComponent<CameraController>();
            _camera.GetComponent<CameraController>().Construct(target);
        }


    }
}