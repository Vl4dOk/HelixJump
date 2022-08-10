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
        private Menu_Levels _menu_Levels;

        private int _numberLevel;
        private bool _isEndlessLevel;


        [SerializeField] private int _numberCharacter = 1;
        [SerializeField] private int _numberCharacterSkin = 6;



        private void Awake()
        {
            _menu_Levels = FindObjectOfType<Menu_Levels>();
        }









        public void StartGame()
        {
            UpdateInfo();

            _game = new GameObject("Game");
            _level = new GameObject("Level"); _level.transform.parent = _game.transform;
            _level.AddComponent<Level>();
            _level.GetComponent<Level>().Construct(_level, _numberLevel, _isEndlessLevel);

            AddPlayer(new Vector3(0, 5, -3), _game.transform);
            GlobalEventManager.Event_StartGame?.Invoke();
        }
   
        private void AddPlayer(Vector3 characterPocition, Transform parent)
        {
            _player = new GameObject("Player"); _player.transform.parent = parent;

            _player.AddComponent<Player>();
            _player.GetComponent<Player>().Construct(_player, characterPocition, _numberCharacter, _numberCharacterSkin);
        }

        public void FinishGame()
        {
            Destroy(_game);
            GlobalEventManager.Event_FinishGame?.Invoke();
        }


        public void RestartGame()
        {
            FinishGame();
            StartGame();
        }

       

        public void NextLevel()
        {
            FinishGame();
            _menu_Levels.NextLevel();
            StartGame();
        }


        private void UpdateInfo()
        {            
            _numberLevel = _menu_Levels.NumberLevel;
            _isEndlessLevel = _menu_Levels.IsEndlessLevel;
        }
    }
}