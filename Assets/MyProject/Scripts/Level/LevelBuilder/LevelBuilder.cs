using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    private Transform _parent;


    private GameObject[] _tierPrefabs;
    private GameObject _newTier;
    private GameObject _newCoins;


    public int _numberLevel, _currentTier, _builtTiers, _maxTier;
    private bool _isLevelFinal = false;
    private bool _isEndlessLevel;



    public void Construct(GameObject[] tierPrefabs, int numberLevel,Transform parent,int maxTier, bool isEndlessLevel)
    {
        _tierPrefabs = tierPrefabs;
        _numberLevel = numberLevel;

        _parent = parent;
        _maxTier = maxTier;
        _isEndlessLevel = isEndlessLevel;
                
        StartLevel();
    }



    public void Continue()
    {
        _currentTier++;

        if (!_isEndlessLevel && _isLevelFinal)
            return;

        if (_builtTiers < _maxTier || _isEndlessLevel == true)
        { AddTier(); }
        else
        { AddFinishTier(); }
    }

    private void StartLevel()
    {
        AddStartTier();       

        for (int i = 0; i < 4; i++)
        { AddTier(); }
    }


    private void AddStartTier()
    {
        _newTier = Instantiate(Resources.Load<GameObject>("Levels/Tiers/Prefabs/StartTierPrefab"), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), _parent);
        _builtTiers++;
    }


    private void AddTier()
    {
        _newTier = Instantiate(_tierPrefabs[Random.Range(0, _tierPrefabs.Length)], new Vector3(0, -6 * _builtTiers, 0), Quaternion.Euler(0, Random.Range(0, 360), 0), _parent);
        _builtTiers++;
       
        AddCoins();
    }


    private void AddFinishTier()
    {
        _newTier = Instantiate(Resources.Load<GameObject>("Levels/Tiers/Prefabs/FinishTierPrefab"), _parent);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);      
        _isLevelFinal = true;
        _builtTiers++;
    }


    public void AddCoins()
    {
        byte probability = (byte)Random.Range(0, 11);

        if (probability >= 5)
        {
            _newCoins = Instantiate(Resources.Load<GameObject>("Levels/Coins/Prefab/CoinsPrefab"), _newTier.transform);
            _newCoins.transform.localPosition = new Vector3(0, Random.Range(0.4f, 1.3f), 0);
            _newCoins.transform.localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360)));
        }
    }




}
