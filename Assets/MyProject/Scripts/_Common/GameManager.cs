using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class GameManager : MonoBehaviour
    {

        private GameObject _player;
        private GameObject _game;
        private GameObject _level;
        private byte _numberLevel = 1;
        private byte _numberCharacter = 1;//////<<<<\/
        private byte _numberCharacterSkin = 1;//<<<</\
        private byte _numberSkinMaterial = 1;
        private bool _isEndlessLevel = false;


       // private byte _numberCharacter;

        public void StartGame()
        {
            AddGame();
            AddLevel();
            AddPlayer(new Vector3(0, 5, -3), _game.transform);


        }

        
        private void AddGame()
        {
            _game = new GameObject("Game");
        }
        private void AddLevel()
        {           
            _level = new GameObject("Level"); _level.transform.parent = _game.transform;
            _level.AddComponent<Level>();
            
        }
        private void AddPlayer(Vector3 position, Transform parent)
        {
            _player = new GameObject("Player"); _player.transform.position = position;  _player.transform.parent = parent;
            
            _player.AddComponent<PlayerController>();
            _player.AddComponent<Player>();
            _player.GetComponent<Player>().Construct(_player, _numberCharacter, _numberCharacterSkin, _numberSkinMaterial);

        }

        public void RestartGame()
        {
            FinishGame();
            StartGame();
        }

        public void FinishGame()
        {
            Destroy(_game);
        }




    }
}