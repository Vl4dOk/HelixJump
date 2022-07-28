using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    private Transform _parent;


    private GameObject[] _tierPrefabs;
    private GameObject _newTier;

   
    private int _maxTier;
    private int _builtTiers;
    private byte _numberLevel;
    private bool _isLevelFinal = false;
    private bool _isEndlessLevel;



    public void Construct(Transform parent, byte numberLevel,int maxTier, bool isEndlessLevel)
    {
        _parent = parent;       
        _numberLevel = numberLevel;
        _maxTier = maxTier;
        _isEndlessLevel = isEndlessLevel;
                
        StartLevel();
    }



    public void Continue()
    {
        if (!_isEndlessLevel && _isLevelFinal)
            return;

        if (_builtTiers <= _maxTier || _isEndlessLevel == true)
        { AddTier(); }
        else
        { AddFinishTier(); }
    }

    private void StartLevel()
    {
        AddStartTier();
        _tierPrefabs = Resources.LoadAll<GameObject>("Levels/LevelsPrefab/Level" + _numberLevel);
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
        //AddCoins();
    }


    private void AddFinishTier()
    {
        _newTier = Instantiate(Resources.Load<GameObject>("Levels/Tiers/Prefabs/FinishTierPrefab"), _parent);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);      
        _isLevelFinal = true;
        _builtTiers++;
    }

    



}
