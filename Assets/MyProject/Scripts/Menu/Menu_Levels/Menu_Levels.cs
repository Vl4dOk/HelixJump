using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Levels : MonoBehaviour
{
    [SerializeField] private GameObject _menu_Levels;
    [SerializeField] private Button[] _buttons_Levels;

    [HideInInspector] public int NumberLevel;
    private int _maxOpenLevel;
    [HideInInspector] public bool IsEndlessLevel = false;


    private void Awake()
    {
        if (_menu_Levels == null) { _menu_Levels = gameObject; }

        LoadingSave();
        GlobalEventManager.Event_PlayerOnFinish += SaveLevel;
        Deactivate_Menu_Levels();
    }


    public void Activate_Menu_Levels() { _menu_Levels.SetActive(true); }
    public void Deactivate_Menu_Levels() { _menu_Levels.SetActive(false); }



    public void ChooseLevel(int numberLevel)
    { NumberLevel = numberLevel; }
    public void ChooseMode()
    { IsEndlessLevel = !IsEndlessLevel; }

    public void NextLevel()
    {
            NumberLevel++; 
        if (NumberLevel > _buttons_Levels.Length)
        {   NumberLevel = 1;}
    }

    private void LoadingSave()
    {
        _maxOpenLevel = PlayerPrefs.GetInt("Levels", 1);
        NumberLevel = _maxOpenLevel;
        for (int i = 0; i < _buttons_Levels.Length; i++)
        { _buttons_Levels[i].interactable = false; }

        for (int i = 0; i < _maxOpenLevel; i++)
        { _buttons_Levels[i].interactable = true; }
    }

    private void SaveLevel()
    {
        if (NumberLevel == _maxOpenLevel && _maxOpenLevel < _buttons_Levels.Length)
        {
            _maxOpenLevel = NumberLevel + 1;
            PlayerPrefs.SetInt("Levels", _maxOpenLevel);

            for (int i = 0; i < _buttons_Levels.Length; i++)
            { _buttons_Levels[i].interactable = false; }
            for (int i = 0; i < _maxOpenLevel; i++)
            { _buttons_Levels[i].interactable = true; }
        }
        if (NumberLevel == _buttons_Levels.Length)
        { NumberLevel = 0; }
    }
}
