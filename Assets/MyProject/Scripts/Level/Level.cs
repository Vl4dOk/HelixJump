using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private GameObject _level;
    private LevelBuilder _levelBuilder;
    private byte _maxTier;


   // private byte _numberLevel;


    public void Construct(GameObject level, Transform parent, byte numberLevel,bool isEndlessLevel)
    {
        _level = level;       
        _maxTier = (byte)(25 + 5 * numberLevel);

        _level.AddComponent<LevelBuilder>();
        _levelBuilder = _level.GetComponent<LevelBuilder>();
        _levelBuilder.Construct(_level.transform, numberLevel, _maxTier, isEndlessLevel);       
    }



}
