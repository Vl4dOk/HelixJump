using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private GameObject _level;
    private int _numberLevel, _maxTier;

    private GameObject[] _tierPrefabs;
    private LevelBuilder _levelBuilder;


    // private byte NumberLevel;


    public void Construct(GameObject level, int numberLevel, bool isEndlessLevel)
    {
        _level = level;
        _numberLevel = numberLevel;

        
        
        FindLevel();
        _maxTier = 25 + 5 * _numberLevel;

        _level.AddComponent<LevelBuilder>();
        _levelBuilder = _level.GetComponent<LevelBuilder>();
        _levelBuilder.Construct(_tierPrefabs, _numberLevel, _level.transform, _maxTier, isEndlessLevel);
    }

    private void FindLevel()
    {
        _tierPrefabs = Resources.LoadAll<GameObject>("Levels/LevelsPrefab/Level" + _numberLevel);

        if (_tierPrefabs == null)
        {
            _numberLevel = 1;
            _tierPrefabs = Resources.LoadAll<GameObject>("Levels/LevelsPrefab/Level" + _numberLevel);
        }
    }



}
