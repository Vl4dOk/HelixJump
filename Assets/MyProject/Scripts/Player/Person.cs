using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Person : MonoBehaviour
    {
        
        private GameObject _player;
        
        private Character _character;
        private CameraPlayer _cameraPlayer;
        private PlayerController _playerController;


        public void Construct(byte numberCharacter, Transform parent)
        {
            _player = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), parent);
            _player.AddComponent<PlayerController>();
            _player.name = "Player" + "";


            _playerController = _player.GetComponent<PlayerController>();
            

            GameObject gameObject = new GameObject();
            switch (numberCharacter)
            {
                case 0:
                    gameObject.AddComponent<CharacterSphere>();
                    _character = gameObject.GetComponent<CharacterSphere>();
                    _playerController._sensitivity = 0.1f;
                    break;
                case 1:
                    gameObject.AddComponent<CharacterCube>();
                    _character = gameObject.GetComponent<CharacterCube>();
                    _playerController._sensitivity = 0.05f;
                    break;
                case 2:
                    gameObject.AddComponent<CharacterSphere>();
                    _character = gameObject.GetComponent<CharacterSphere>();
                    _playerController._sensitivity = 0.075f;
                    break;
                case 3:                    
                    gameObject.AddComponent<CharacterSphere>();
                    _character = gameObject.GetComponent<CharacterSphere>();
                    _playerController._sensitivity = 0.075f;
                    break;
            }
            _character.Construct(_player.transform);

            gameObject.AddComponent<CameraPlayer>();
            _cameraPlayer = gameObject.GetComponent<CameraPlayer>();
            _cameraPlayer.Construct(_character._Character.transform, _player.transform);

            Destroy(gameObject);




        }



    }
}