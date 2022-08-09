using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class GameManager : MonoBehaviour
    {

        private GameObject _game;
        private GameObject _player;
        private GameObject _level;


        [SerializeField] private byte _numberLevel = 1;
        [SerializeField] private bool _isEndlessLevel = false;


        [SerializeField] private byte _numberCharacter = 1;
        [SerializeField] private byte _numberCharacterSkin = 6;





        public void StartGame()
        {
            _game = new GameObject("Game");
            _level = new GameObject("Level"); _level.transform.parent = _game.transform;
            _level.AddComponent<Level>();
            _level.GetComponent<Level>().Construct(_level, _numberLevel, _isEndlessLevel);

            AddPlayer(new Vector3(0, 5, -3), _game.transform);
        }
   
        private void AddPlayer(Vector3 characterPocition, Transform parent)
        {
            _player = new GameObject("Player"); _player.transform.parent = parent;

            _player.AddComponent<Player>();
            _player.GetComponent<Player>().Construct(_player, characterPocition, _numberCharacter, _numberCharacterSkin);

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

        public void NextLevel()
        {
            Destroy(_game);
            _numberLevel++;
            StartGame();
        }



    }
}