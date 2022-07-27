using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class GameManager : MonoBehaviour
    {
        

        private GameObject _game;
        private Level _level;
        private byte _numberLevel = 1;
        private byte _numberCharacter = 1;
        private bool _isEndlessLevel = false;


        private Person _player;
       // private byte _numberCharacter;

        public void StartGame()
        {
            AddGame();
            AddLevel();
            AddPerson();


        }

        
        private void AddGame()
        {
            _game = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0)) ;
            _game.name = "Game";
        }
        private void AddLevel()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<Level>();
            _level = gameObject.GetComponent<Level>();
            _level.Construct(_game.transform, _numberLevel, _isEndlessLevel);
            Destroy(gameObject);
        }
        private void AddPerson()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<Person>();
            _player = gameObject.GetComponent<Person>();
            _player.Construct(_numberCharacter ,_game.transform);
            Destroy(gameObject);
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