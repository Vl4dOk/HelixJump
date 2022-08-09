using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface_Player : MonoBehaviour
{
    [SerializeField] private GameObject _interface_Payer;
    private PlayerInventory _playerInventory;
    private LevelBuilder _levelBuilder;

    [SerializeField] private Text _currentLevel, _nextLevel;
    [SerializeField] private Slider _sliderProgress;

    [SerializeField] private Text _currentTier;
    [SerializeField] private Text _recordTier;
    [SerializeField] private Text _scoreCoins;



    private void OnEnable()
    {



        _playerInventory = FindObjectOfType<PlayerInventory>();

        _levelBuilder = FindObjectOfType<LevelBuilder>();
        _sliderProgress.maxValue = _levelBuilder._maxTier;

       
    }

    private void Update()
    {
        _currentLevel.text = _levelBuilder._numberLevel.ToString();
        _nextLevel.text = (_levelBuilder._numberLevel + 1).ToString();
        _sliderProgress.value = _levelBuilder._currentTier;


        _currentTier.text = "Tier: " + _levelBuilder._currentTier;
        _recordTier.text = "Record: " + _playerInventory.Achievements["RecordTier"];
        _scoreCoins.text = "Coins: " + _playerInventory.Consumables["Coins"];
    }



    public void Calling_interface_Payer(){ _interface_Payer.SetActive(true);}
    public void Close_interface_Payer()  { _interface_Payer.SetActive(false);}

}
