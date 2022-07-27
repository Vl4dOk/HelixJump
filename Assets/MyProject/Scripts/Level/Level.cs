using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private GameObject _currentLevel;
    private LevelBuilder _levelBuilder;
    private byte _maxTier;


   // private byte _numberLevel;


    public void Construct(Transform parent, byte numberLevel,bool isEndlessLevel)
    {
        _currentLevel = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), parent);
        _currentLevel.name = "CurrentLevel " + numberLevel;
        _maxTier = (byte)(25 + 5 * numberLevel);

        _currentLevel.AddComponent<LevelBuilder>();
        _levelBuilder = _currentLevel.GetComponent<LevelBuilder>();
        _levelBuilder.Construct(_currentLevel.transform, numberLevel, _maxTier, isEndlessLevel);
       




    }



}
