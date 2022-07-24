using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static Level MainLevel; private void Awake()
    {
        if (MainLevel == null) { MainLevel = this; }
        else if (MainLevel != this) { Destroy(gameObject); }
    }

    public GameObject GO_Level;
    [HideInInspector] public int NumberLevel;
    [HideInInspector] public int MaxTier;

    public GameObject[] _tiersPrefab;
    private GameObject _startTierPrefab, _finishTierPrefab, _coinsPrefab;


    private GameObject _newTier, _newCoins;
    private int _builtTiers, _currentTier;
    [HideInInspector] public bool IsControlPlayer = false;


    /*public Level(byte numberLevel,Transform parent,bool isEndlessLevel = false)
    {
        GO_Level = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
        GO_Level.name = "Level" + numberLevel;

        _tiersPrefab = Resources.LoadAll<GameObject>("Tier/Levels/Levels" + numberLevel);
        _startTierPrefab = Resources.Load<GameObject>("Tier/Prefabs/StartTierPrefab");
        _finishTierPrefab = Resources.Load<GameObject>("Tier/Prefabs/FinishTierPrefab");
        NumberLevel = numberLevel;
        
        MaxTier = 25 + numberLevel * 5;



        _coinsPrefab = Resources.Load<GameObject>("Coins/Prefab/CoinsPrefab");
        BuildLevel();
    }*/

    public void ConstrLevel(byte numberLevel,Transform parent,bool isEndlessLevel = false)
    {
        GO_Level = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
        GO_Level.name = "Level" + numberLevel;

        _tiersPrefab = Resources.LoadAll<GameObject>("Tier/Levels/Level" + numberLevel);
        _startTierPrefab = Resources.Load<GameObject>("Tier/Prefabs/StartTierPrefab");
        _finishTierPrefab = Resources.Load<GameObject>("Tier/Prefabs/FinishTierPrefab");
        NumberLevel = numberLevel;
        
        MaxTier = 25 + numberLevel * 5;



        _coinsPrefab = Resources.Load<GameObject>("Coins/Prefab/CoinsPrefab");
        BuildLevel();
    }

    public void BuildLevel()
    {
        IsControlPlayer = true;        

        AddStartTier();
        AddTier(); AddTier(); AddTier();
    }





    public void AddStartTier()
    {
        _newTier = Instantiate(_startTierPrefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), GO_Level.transform);
        _builtTiers++;
    }

    public void AddTier()
    {
        _newTier = Instantiate(_tiersPrefab[Random.Range(0, _tiersPrefab.Length)], GO_Level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _newTier.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        _builtTiers++;
        AddCoins();
    }

    public void AddFinishTier()
    {
        _newTier = Instantiate(_finishTierPrefab, GO_Level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _builtTiers++;
    }

    public void AddCoins()
    {
        byte probability = (byte)Random.Range(0, 11);

        if (probability >= 5)
        {
            _newCoins = Instantiate(_coinsPrefab, _newTier.transform);
            _newCoins.transform.localPosition = new Vector3(0, Random.Range(0.4f, 1.5f), 0);
            _newCoins.transform.localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360)));
        }
    }

}
